using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

public class MyCustomEditorWindow3 : OdinMenuEditorWindow
{
    [MenuItem("My Game/My Editor3")]
    private static void OpenWindow()
    {
        GetWindow<MyCustomEditorWindow3>().Show();
    }

    protected override OdinMenuTree BuildMenuTree()
    {
        var tree = new OdinMenuTree();
        tree.DefaultMenuStyle = OdinMenuStyle.TreeViewStyle;

        tree.Add("Menu Style", tree.DefaultMenuStyle);

        var allAssets = AssetDatabase.GetAllAssetPaths()
            .Where(x => x.StartsWith("Assets/"))
            .OrderBy(x => x);

        foreach (var path in allAssets)
        {
            tree.AddAssetAtPath(path.Substring("Assets/".Length), path);
        }

        //EnumerateTree会枚举菜单树中的所有项目，返回一个可枚举的菜单项集合。
        //AddThumbnailIcons是对这个集合的扩展方法，它会为菜单树中的每个项目添加缩略图图标。
        tree.EnumerateTree().AddThumbnailIcons();

        return tree;
    }
}
