using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class FilePathDemo : MonoBehaviour
{
    // By default, FolderPath provides a path relative to the Unity project.
    [FilePath]
    public string UnityProjectPath;

    // It is possible to provide custom parent path. Parent paths can be relative to the Unity project, or absolute.
    [FilePath(ParentFolder = "Assets/Plugins/Sirenix")]
    public string RelativeToParentPath; // 提供自定义父路径，父路径可以是相对于Unity项目，也可以是绝对路径

    // Using parent path, FilePath can also provide a path relative to a resources folder.
    [FilePath(ParentFolder = "Assets/Resources")]
    public string ResourcePath;

    // Provide a comma seperated list of allowed extensions. Dots are optional.
    [FilePath(Extensions = "cs")]
    [BoxGroup("Conditions")]
    public string ScriptFiles; // 提供逗号分隔的允许的扩展名，点号是可选的

    // By setting AbsolutePath to true, the FilePath will provide an absolute path instead.
    [FilePath(AbsolutePath = true)]
    [BoxGroup("Conditions")]
    public string AbsolutePath; // 设置为true，FilePath将提供一个绝对路径

    // FilePath can also be configured to show an error, if the provided path is invalid.
    [FilePath(RequireExistingPath = true)]
    [BoxGroup("Conditions")]
    public string ExistingPath; // 设置为true，FilePath将显示一个错误，如果提供的路径无效

    // By default, FilePath will enforce the use of forward slashes. It can also be configured to use backslashes instead.
    [FilePath(UseBackslashes = true)]
    [BoxGroup("Conditions")]
    public string Backslashes; // 默认情况下，FilePath将强制使用正斜杠。也可以配置为使用反斜杠

    // FilePath also supports member references with the $ symbol.
    [FilePath(ParentFolder = "$DynamicParent", Extensions = "$DynamicExtensions")]
    [BoxGroup("Member referencing")]
    public string DynamicFilePath; // 支持使用$符号引用成员

    [BoxGroup("Member referencing")]
    public string DynamicParent = "Assets/Plugins/Sirenix";

    [BoxGroup("Member referencing")]
    public string DynamicExtensions = "cs, unity, jpg";

    // FilePath also supports lists and arrays.
    [FilePath(ParentFolder = "Assets/Plugins/Sirenix/Demos/Odin Inspector")]
    [BoxGroup("Lists")]
    public string[] ListOfFiles; // 支持列表和数组
}
