using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

public class InlineEditorDemo : MonoBehaviour
{
    [InlineEditor]
    public ExampleTransformDemo InlineComponent;
    [Title("Boxed / Default")]
    [InlineEditor(InlineEditorObjectFieldModes.Boxed)]
    public ExampleTransformDemo Boxed; //默认，在盒子中显示

    [Title("Foldout")]
    [InlineEditor(InlineEditorObjectFieldModes.Foldout)]
    public ExampleTransformDemo Foldout; //折叠显示

    [Title("Hide ObjectField")]
    [InlineEditor(InlineEditorObjectFieldModes.CompletelyHidden)]
    public ExampleTransformDemo CompletelyHidden; //总是隐藏

    [Title("Show ObjectField if null")]
    [InlineEditor(InlineEditorObjectFieldModes.Hidden)]
    public ExampleTransformDemo OnlyHiddenWhenNotNull; //仅在对象为null时显示

    [Space(50)]

    [InlineEditor(InlineEditorModes.FullEditor)]
    public Material FullInlineEditor;

    [InlineEditor(InlineEditorModes.GUIAndHeader)]
    public Material InlineMaterial;

    [InlineEditor(InlineEditorModes.SmallPreview)]
    public Material[] InlineMaterialList;

    [InlineEditor(InlineEditorModes.LargePreview)]
    public Mesh InlineMeshPreview;

    // You can also use the InlineEditor attribute directly on a class definition itself!
    //[InlineEditor]
    //public class ExampleTransform : ScriptableObject
    //{
    //    public Vector3 Position;
    //    public Quaternion Rotation;
    //    public Vector3 Scale = Vector3.one;
    //}

    [OnInspectorInit]
    private void CreateData()
    {
        FullInlineEditor = ExampleHelper.GetMaterial();
        InlineMaterial = ExampleHelper.GetMaterial();
        InlineMaterialList = new Material[]
        {
        ExampleHelper.GetMaterial(),
        ExampleHelper.GetMaterial(),
        ExampleHelper.GetMaterial(),
        };
        InlineMeshPreview = ExampleHelper.GetMesh();
    }
}
