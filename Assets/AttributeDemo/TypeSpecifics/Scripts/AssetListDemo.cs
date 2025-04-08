using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class AssetListDemo : MonoBehaviour
{
    [AssetList]
    [PreviewField(70, ObjectFieldAlignment.Center)]
    public Texture2D SingleObject;

    [AssetList(Path = "/Plugins/Sirenix/")] // 指定路径，这个路径下的资源会被自动添加到列表中,可以指定是否启用
    public List<ScriptableObject> AssetList;

    [FoldoutGroup("Filtered Odin ScriptableObjects", expanded: false)]
    [AssetList(Path = "Plugins/Sirenix/")]
    public ScriptableObject Object;

    [AssetList(AutoPopulate = true, Path = "Plugins/Sirenix/")] // 自动填充，当Inspector窗口打开时，会自动填充列表
    [FoldoutGroup("Filtered Odin ScriptableObjects", expanded: false)]
    public List<ScriptableObject> AutoPopulatedWhenInspected;

    [AssetList(LayerNames = "MyLayerName")] //筛选所有Layer为MyLayerName的预制
    [FoldoutGroup("Filtered AssetLists examples")]
    public GameObject[] AllPrefabsWithLayerName;

    [AssetList(AssetNamePrefix = "Rock")] // 筛选所有名称以Rock开头的预制
    [FoldoutGroup("Filtered AssetLists examples")]
    public List<GameObject> PrefabsStartingWithRock;

    [FoldoutGroup("Filtered AssetLists examples")]
    [AssetList(Tags = "MyTagA, MyTagB", Path = "/Demo/TypeSpecifics/")] // 筛选所有标签为MyTagA或MyTagB的预制
    public List<GameObject> GameObjectsWithTag;

    [FoldoutGroup("Filtered AssetLists examples")]
    [AssetList(CustomFilterMethod = "HasRigidbodyComponent")] // 自定义筛选方法，筛选所有具有Rigidbody组件的预制
    public List<GameObject> MyRigidbodyPrefabs;

    private bool HasRigidbodyComponent(GameObject obj)
    {
        return obj.GetComponent<Rigidbody>() != null;
    }

    void Awake()
    {
        Debug.Log($"AssetList: {AssetList.Count}");
        Debug.Log($"AutoPopulatedWhenInspected: {AutoPopulatedWhenInspected.Count}");
        Debug.Log($"AllPrefabsWithLayerName: {AllPrefabsWithLayerName.Length}");
        Debug.Log($"PrefabsStartingWithRock: {PrefabsStartingWithRock.Count}");
        Debug.Log($"GameObjectsWithTag: {GameObjectsWithTag.Count}");
        Debug.Log($"MyRigidbodyPrefabs: {MyRigidbodyPrefabs.Count}");
    }
}
