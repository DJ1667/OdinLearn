using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

public class ValueDropdownDemo : MonoBehaviour
{
    [ValueDropdown("TextureSizes")]
    public int SomeSize1;

    [ValueDropdown("FriendlyTextureSizes")]
    public int SomeSize2;

    [ValueDropdown("FriendlyTextureSizes", AppendNextDrawer = true, DisableGUIInAppendedDrawer = true)]
    public int SomeSize3; //AppendNextDrawer = true 附加一个小按钮，DisableGUIInAppendedDrawer = true 禁用下拉框

    [ValueDropdown("GetListOfMonoBehaviours", AppendNextDrawer = true)]
    public MonoBehaviour SomeMonoBehaviour;

    [ValueDropdown("KeyCodes")]
    public KeyCode FilteredEnum;

    [ValueDropdown("TreeViewOfInts", ExpandAllMenuItems = true)]
    public List<int> IntTreview = new List<int>() { 1, 2, 7 };

    [ValueDropdown("GetAllSceneObjects", IsUniqueList = true)]
    public List<GameObject> UniqueGameobjectList;

    //IsUniqueList = true 列表内容的唯一性，DrawDropdownForListElements = false 不为列表中的元素绘制下拉框，ExcludeExistingValuesInList = true 排除重复值
    [ValueDropdown("GetAllSceneObjects", IsUniqueList = true, DropdownTitle = "Select Scene Object", DrawDropdownForListElements = false, ExcludeExistingValuesInList = true)]
    public List<GameObject> UniqueGameobjectListMode2;

    private IEnumerable TreeViewOfInts = new ValueDropdownList<int>()
    {
        { "Node 1/Node 1.1", 1 },
        { "Node 1/Node 1.2", 2 },
        { "Node 2/Node 2.1", 3 },
        { "Node 3/Node 3.1", 4 },
        { "Node 3/Node 3.2", 5 },
        { "Node 1/Node 3.1/Node 3.1.1", 6 },
        { "Node 1/Node 3.1/Node 3.1.2", 7 },
    };

    private IEnumerable<MonoBehaviour> GetListOfMonoBehaviours()
    {
        return GameObject.FindObjectsOfType<MonoBehaviour>();
    }

    private static IEnumerable<KeyCode> KeyCodes = Enumerable.Range((int)KeyCode.Alpha0, 10).Cast<KeyCode>();

    private static IEnumerable GetAllSceneObjects()
    {
        Func<Transform, string> getPath = null;
        getPath = x => (x ? getPath(x.parent) + "/" + x.gameObject.name : "");
        return GameObject.FindObjectsOfType<GameObject>().Select(x => new ValueDropdownItem(getPath(x.transform), x));
    }

    private static IEnumerable GetAllScriptableObjects()
    {
        return UnityEditor.AssetDatabase.FindAssets("t:ScriptableObject")
            .Select(x => UnityEditor.AssetDatabase.GUIDToAssetPath(x))
            .Select(x => new ValueDropdownItem(x, UnityEditor.AssetDatabase.LoadAssetAtPath<ScriptableObject>(x)));
    }

    private static IEnumerable GetAllSirenixAssets()
    {
        var root = "Assets/Plugins/Sirenix/";

        return UnityEditor.AssetDatabase.GetAllAssetPaths()
            .Where(x => x.StartsWith(root))
            .Select(x => x.Substring(root.Length))
            .Select(x => new ValueDropdownItem(x, UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(root + x)));
    }

    private static IEnumerable FriendlyTextureSizes = new ValueDropdownList<int>() //相当于给你的可选择值起了个名字,实际的值还是256,512,1024
    {
        { "Small", 256 }, //name - value
        { "Medium", 512 },
        { "Large", 1024 },
    };

    private static int[] TextureSizes = new int[] { 256, 512, 1024 };
}
