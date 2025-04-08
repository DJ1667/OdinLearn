using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class FolderPathDemo : MonoBehaviour
{
    // By default, FolderPath provides a path relative to the Unity project.
    [FolderPath]
    public string UnityProjectPath; // 从unity的根目录开始

    // It is possible to provide custom parent path. Parent paths can be relative to the Unity project, or absolute.
    [FolderPath(ParentFolder = "Assets/Plugins/Sirenix")]
    public string RelativeToParentPath; //从Sirenix下一级目录开始, 所见即所得,并非完整路径

    // Using parent path, FolderPath can also provide a path relative to a resources folder.
    [FolderPath(ParentFolder = "Assets/Resources")]
    public string ResourcePath; //从Resources下一级目录开始

    // By setting AbsolutePath to true, the FolderPath will provide an absolute path instead.
    [FolderPath(AbsolutePath = true)]
    [BoxGroup("Conditions")]
    public string AbsolutePath;

    // FolderPath can also be configured to show an error, if the provided path is invalid.
    [FolderPath(RequireExistingPath = true)]
    [BoxGroup("Conditions")]
    public string ExistingPath; // 如果路径不存在，会提示错误

    // By default, FolderPath will enforce the use of forward slashes. It can also be configured to use backslashes instead.
    [FolderPath(UseBackslashes = true)]
    [BoxGroup("Conditions")]
    public string Backslashes; // 使用反斜杠

    // FolderPath also supports member references and attribute expressions with the $ symbol.
    [FolderPath(ParentFolder = "$DynamicParent")]
    [BoxGroup("Member referencing")]
    public string DynamicFolderPath; // 使用动态父路径

    [BoxGroup("Member referencing")]
    public string DynamicParent = "Assets/Plugins/Sirenix";

    // FolderPath also supports lists and arrays.
    [FolderPath(ParentFolder = "Assets/Plugins/Sirenix")]
    [BoxGroup("Lists")]
    public string[] ListOfFolders; // 支持列表和数组

    void Awake()
    {
        Debug.Log("UnityProjectPath: " + UnityProjectPath);
        Debug.Log("RelativeToParentPath: " + RelativeToParentPath);
        Debug.Log("ResourcePath: " + ResourcePath);
        Debug.Log("AbsolutePath: " + AbsolutePath);
        Debug.Log("ExistingPath: " + ExistingPath);
        Debug.Log("Backslashes: " + Backslashes);
        Debug.Log("DynamicFolderPath: " + DynamicFolderPath);
    }
}
