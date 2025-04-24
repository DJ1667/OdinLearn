using Sirenix.OdinInspector.Editor.Validation;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
using Sirenix.OdinValidator.Editor;

public class CustomValidationPipeline : MonoBehaviour
{
    private static string LogPath = Application.dataPath.Replace("Assets", "Logs");

    [MenuItem("工具/验证项目")]
    public static void ValidateProject()
    {
        // 获取主验证配置文件
        var profile = ValidationProfile.MainValidationProfile;

        // 或者引用自定义配置文件
        // var profile = AssetDatabase.LoadAssetAtPath<ValidationProfile>("Assets/ValidationProfiles/BuildValidation.asset");

        Debug.Log("开始验证项目...");
        int errorCount = 0;
        int warningCount = 0;

        using (var session = new ValidationSession(profile))
        {
            foreach (var result in session.ValidateEverythingEnumerator(openClosedScenes: true, showProgressBar: true))
            {
                switch (result.ResultType)
                {
                    case ValidationResultType.Error:
                        errorCount++;
                        Debug.LogError($"验证错误: {result.Message} - 位置: {GetObjectFilePath(result)}");
                        break;

                    case ValidationResultType.Warning:
                        warningCount++;
                        Debug.LogWarning($"验证警告: {result.Message} - 位置: {GetObjectFilePath(result)}");
                        break;
                }
            }

            // 生成并保存报告
            string timestamp = System.DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // 生成JSON报告
            string jsonReport = session.ToJson();
            File.WriteAllText($"{LogPath}/ValidationReport_{timestamp}.json", jsonReport);

            // 生成HTML报告
            string htmlReport = session.ToHtml();
            File.WriteAllText($"{LogPath}/ValidationReport_{timestamp}.html", htmlReport);
        }

        string resultMessage = $"验证完成! 发现 {errorCount} 个错误和 {warningCount} 个警告。";

        if (errorCount > 0)
        {
            Debug.LogError(resultMessage);
        }
        else if (warningCount > 0)
        {
            Debug.LogWarning(resultMessage);
        }
        else
        {
            Debug.Log(resultMessage + " 验证通过!");
        }
    }


    public static string GetObjectFilePath(PersistentValidationResult validationResult)
    {
        if (validationResult.DynamicObjectAddress == null ||
            validationResult.DynamicObjectAddress.LatestAddress == null)
        {
            return "无效地址";
        }

        var address = validationResult.DynamicObjectAddress.LatestAddress;

        // 对于资产类型对象
        if (address.Type == ObjectAddress.AddressType.Asset)
        {
            return AssetDatabase.GUIDToAssetPath(address.AssetGUID);
        }

        // 对于场景中的GameObject和Component
        else if (address.Type == ObjectAddress.AddressType.SceneGameObject ||
                 address.Type == ObjectAddress.AddressType.SceneComponent)
        {
            // 获取场景资产路径
            string scenePath = AssetDatabase.GUIDToAssetPath(address.AssetGUID);

            // 对于场景对象，我们可以补充场景内路径信息
            if (!string.IsNullOrEmpty(address.AssetPath))
            {
                return $"{scenePath}:{address.AssetPath}";
            }

            return scenePath;
        }

        return "未知路径类型";
    }
}