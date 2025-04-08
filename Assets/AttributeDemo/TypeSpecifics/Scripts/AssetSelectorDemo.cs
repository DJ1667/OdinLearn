using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class AssetSelectorDemo : MonoBehaviour
{
    [AssetSelector]
    public Material AnyAllMaterials; // 选择任意材质，默认树形结构展示

    [AssetSelector]
    public Material[] ListOfAllMaterials; // 选择多个材质，默认树形结构展示, 按加号添加，可同时选择多个

    [AssetSelector(FlattenTreeView = true)]
    public Material NoTreeView; // 不显示树形结构，只显示列表

    [AssetSelector(Paths = "Assets/Plugins/Sirenix")]
    public ScriptableObject ScriptableObjectsFromFolder; // 选择指定路径下的资源

    [AssetSelector(Paths = "Assets/Demo/TypeSpecifics/Mat|Assets/Demo/Essentials")]
    public Material ScriptableObjectsFromMultipleFolders; // 选择多个路径下的资源

    [AssetSelector(Filter = "Cube")]
    public UnityEngine.Object AssetDatabaseSearchFilters1; // 筛选所有名字包含Cube的资源
    [AssetSelector(Filter = "t:Prefab")]
    public UnityEngine.Object AssetDatabaseSearchFilters2; // 筛选所有预制体
    [AssetSelector(Filter = "t:Prefab l:Terrain")]
    public UnityEngine.Object AssetDatabaseSearchFilters3; // 筛选所有预制体，并且标签是Terrain
    [AssetSelector(Filter = "RedRock t:Prefab l:Terrain")]
    public UnityEngine.Object AssetDatabaseSearchFilters4; // 筛选所有预制体，并且名字包含RedRock，并且标签是Terrain

    [Title("Other Minor Features")]
    [AssetSelector(DisableListAddButtonBehaviour = true)]
    public List<GameObject> DisableListAddButtonBehaviour; // 禁用列表添加按钮的功能

    [AssetSelector(DrawDropdownForListElements = false)]
    public List<GameObject> DisableListElementBehaviour; // 禁用列表中元素的AssetSelector功能

    [AssetSelector(ExcludeExistingValuesInList = true)]
    public List<GameObject> ExcludeExistingValuesInList; // 排除已选中的元素

    [AssetSelector(IsUniqueList = false)]
    public List<GameObject> DisableUniqueListBehaviour; // 禁用列表中元素的唯一性，可以重复选择

    [AssetSelector(ExpandAllMenuItems = true)]
    public List<GameObject> ExpandAllMenuItems; // 展开所有菜单项, 不设置默认也是true

    [AssetSelector(DropdownTitle = "Custom Dropdown Title")]
    public List<GameObject> CustomDropdownTitle; // 自定义下拉菜单标题
}
