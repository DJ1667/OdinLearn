using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

public class EnableAndDisable : MonoBehaviour
{
    public UnityEngine.Object SomeObject;

    [EnumToggleButtons]
    public InfoMessageType SomeEnum;

    public bool IsToggled;

    [DisableIf("SomeEnum", InfoMessageType.Info)]
    public Vector2 Info;

    [DisableIf("SomeEnum", InfoMessageType.Error)]
    public Vector2 Error;

    [DisableIf("SomeEnum", InfoMessageType.Warning)]
    public Vector2 Warning;

    [DisableIf("IsToggled")]
    public int DisableIfToggled;

    [DisableIf("SomeObject")]
    public Vector3 EnabledWhenNull;

    [DisableIf("@this.IsToggled && this.SomeObject != null || this.SomeEnum == InfoMessageType.Error")]
    public int DisableWithExpression;

    //======================================================================================

    [Space(50)]
    [DisableIn(PrefabKind.InstanceInScene)]
    public string InstanceInScene = "Instances of prefabs in scenes";

    [DisableIn(PrefabKind.InstanceInPrefab)]
    public string InstanceInPrefab = "Instances of prefabs nested inside other prefabs";

    [DisableIn(PrefabKind.Regular)]
    public string Regular = "Regular prefab assets";

    [DisableIn(PrefabKind.Variant)]
    public string Variant = "Prefab variant assets";

    [DisableIn(PrefabKind.NonPrefabInstance)]
    public string NonPrefabInstance = "Non-prefab component or gameobject instances in scenes";

    [DisableIn(PrefabKind.PrefabInstance)]
    public string PrefabInstance = "Instances of regular prefabs, and prefab variants in scenes or nested in other prefabs";

    [DisableIn(PrefabKind.PrefabAsset)]
    public string PrefabAsset = "Prefab assets and prefab variant assets";

    [DisableIn(PrefabKind.PrefabInstanceAndNonPrefabInstance)]
    public string PrefabInstanceAndNonPrefabInstance = "Prefab Instances, as well as non-prefab instances";

    //===============================================================================

    [Space(50)]
    [Title("Disabled in edit mode")]
    [DisableInEditorMode]
    public GameObject A;

    [DisableInEditorMode]
    public Material B;

    //===============================================================================

    [Space(50)]
    [InfoBox("Click the pen icon to open a new inspector window for the InlineObject too see the difference this attribute makes.")]
    [InlineEditor(Expanded = true)]
    public DisabledInInlineEditorScriptableObjectDemo InlineObject;

    //===============================================================================
    [Space(50)]
    [Title("Disabled in play mode")]
    [DisableInPlayMode]
    public int A2;

    [DisableInPlayMode]
    public Material B2;

    //===============================================================================
    [Space(50)]
    public bool IsToggled2;

    [EnableIf("SomeEnum", InfoMessageType.Info)]
    public Vector2 Info2;

    [EnableIf("SomeEnum", InfoMessageType.Error)]
    public Vector2 Error2;

    [EnableIf("SomeEnum", InfoMessageType.Warning)]
    public Vector2 Warning2;

    [EnableIf("IsToggled")]
    public int EnableIfToggled;

    [EnableIf("SomeObject")]
    public Vector3 EnabledWhenHasReference;

    [EnableIf("@this.IsToggled && this.SomeObject != null || this.SomeEnum == InfoMessageType.Error")]
    public int EnableWithExpression;

    //===============================================================================
    [Space(50)]

    [EnableIn(PrefabKind.InstanceInScene)]
    public string InstanceInScene2 = "Instances of prefabs in scenes";

    [EnableIn(PrefabKind.InstanceInPrefab)]
    public string InstanceInPrefab2 = "Instances of prefabs nested inside other prefabs";

    [EnableIn(PrefabKind.Regular)]
    public string Regular2 = "Regular prefab assets";

    [EnableIn(PrefabKind.Variant)]
    public string Variant2 = "Prefab variant assets";

    [EnableIn(PrefabKind.NonPrefabInstance)]
    public string NonPrefabInstance2 = "Non-prefab component or gameobject instances in scenes";

    [EnableIn(PrefabKind.PrefabInstance)]
    public string PrefabInstance2 = "Instances of regular prefabs, and prefab variants in scenes or nested in other prefabs";

    [EnableIn(PrefabKind.PrefabAsset)]
    public string PrefabAsset2 = "Prefab assets and prefab variant assets";

    [EnableIn(PrefabKind.PrefabInstanceAndNonPrefabInstance)]
    public string PrefabInstanceAndNonPrefabInstance2 = "Prefab Instances, as well as non-prefab instances";
}
