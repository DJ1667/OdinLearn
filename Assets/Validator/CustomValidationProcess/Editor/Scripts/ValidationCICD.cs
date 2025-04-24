using Sirenix.OdinInspector.Editor.Validation;
using UnityEditor;
using UnityEngine;
using System.IO;
using System;
using Sirenix.OdinValidator.Editor;

public static class ValidationCICD
{
    /// <summary>
    /// 命令行调用的验证方法，可在CI/CD中使用
    /// 用法: Unity.exe -batchmode -projectPath [项目路径] -executeMethod ValidationCICD.ValidateForBuild -logFile [日志文件] -quit
    /// </summary>
    public static void ValidateForBuild()
    {
        try
        {
            Debug.Log("开始CI/CD验证过程...");

            // 加载构建验证配置
            var buildProfile = AssetDatabase.LoadAssetAtPath<ValidationProfile>("Assets/ValidationProfiles/BuildValidation.asset");
            if (buildProfile == null)
            {
                Debug.LogError("无法加载构建验证配置文件，使用主验证配置文件");
                buildProfile = ValidationProfile.MainValidationProfile;

                if (buildProfile == null)
                {
                    throw new Exception("无法找到任何验证配置文件");
                }
            }

            int errorCount = 0;

            using (var session = new ValidationSession(buildProfile))
            {
                foreach (var result in session.ValidateEverythingEnumerator(openClosedScenes: true, showProgressBar: false))
                {
                    if (result.ResultType == ValidationResultType.Error)
                    {
                        errorCount++;
                        Debug.LogError($"[验证错误] {result.Message} - 位置: {GetObjectFilePath(result)}");
                    }
                }

                // 生成报告
                string reportsPath = "BuildReports";
                if (!Directory.Exists(reportsPath))
                {
                    Directory.CreateDirectory(reportsPath);
                }

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                string jsonPath = Path.Combine(reportsPath, $"ValidationReport_{timestamp}.json");
                File.WriteAllText(jsonPath, session.ToJson());

                string htmlPath = Path.Combine(reportsPath, $"ValidationReport_{timestamp}.html");
                File.WriteAllText(htmlPath, session.ToHtml());

                Debug.Log($"验证报告已保存到: {reportsPath}");
            }

            if (errorCount > 0)
            {
                throw new Exception($"验证失败! 发现 {errorCount} 个错误，构建中止。");
            }

            Debug.Log("验证成功，可以继续构建过程。");
        }
        catch (Exception e)
        {
            Debug.LogError($"验证过程出错: {e.Message}");
            // 在CI/CD环境中，我们需要一个非零的退出码来表示失败
            EditorApplication.Exit(1);
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