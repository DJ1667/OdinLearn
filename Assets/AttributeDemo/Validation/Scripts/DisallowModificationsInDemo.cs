using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class DisallowModificationsInDemo : MonoBehaviour
{
    [DisallowModificationsIn(PrefabKind.PrefabInstanceAndNonPrefabInstance)]
    public string PrefabInstanceAndNonPrefabInstance = "Prefab Instances, as well as non-prefab instances";

    [DisallowModificationsIn(PrefabKind.InstanceInScene)]
    public string InstanceInScene = "Instances of prefabs in scenes";

    [DisallowModificationsIn(PrefabKind.InstanceInPrefab)]
    public string InstanceInPrefab = "Instances of prefabs nested inside other prefabs";

    [DisallowModificationsIn(PrefabKind.Variant)]
    public string Variant = "Prefab variant assets";

    [DisallowModificationsIn(PrefabKind.NonPrefabInstance)]
    public string NonPrefabInstance = "Non-prefab component or gameobject instances in scenes";

    [DisallowModificationsIn(PrefabKind.PrefabInstance)]
    public string PrefabInstance = "Instances of regular prefabs, and prefab variants in scenes or nested in other prefabs";
}
