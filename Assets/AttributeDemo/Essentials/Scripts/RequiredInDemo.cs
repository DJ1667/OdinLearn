using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class RequiredInDemo : MonoBehaviour
{
    [RequiredIn(PrefabKind.InstanceInScene, ErrorMessage = "Error messages can be customized. Odin expressions is supported.")]
    public GameObject InstanceInScene;  //在场景中的实例

    [RequiredIn(PrefabKind.InstanceInPrefab)]
    public GameObject InstanceInPrefab;  //在预制体中的实例

    [RequiredIn(PrefabKind.Regular)]
    public GameObject Regular;  //常规预制体

    [RequiredIn(PrefabKind.Variant)]
    public GameObject Variant;  //变体预制体

    [RequiredIn(PrefabKind.NonPrefabInstance)]
    public GameObject NonPrefabInstance;  //非预制体实例

    [RequiredIn(PrefabKind.PrefabInstance)]
    public GameObject PrefabInstance;  //预制体实例

    [RequiredIn(PrefabKind.PrefabAsset)]
    public GameObject PrefabAsset;  //预制体资产

    [RequiredIn(PrefabKind.PrefabInstanceAndNonPrefabInstance)]
    public GameObject PrefabInstanceAndNonPrefabInstance;  //预制体实例和非预制体实例
}
