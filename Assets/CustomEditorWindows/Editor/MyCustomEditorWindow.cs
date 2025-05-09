using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

public class MyCustomEditorWindow : OdinEditorWindow
{
    [MenuItem("My Game/My Editor")]
    private static void OpenWindow()
    {
        GetWindow<MyCustomEditorWindow>().Show();
    }

    // protected override object GetTarget()
    // {
    //     return Selection.activeObject;
    // }

    [EnumToggleButtons, BoxGroup("Settings")]
    public ScaleMode ScaleMode;

    [FolderPath(RequireExistingPath = true), BoxGroup("Settings")]
    public string OutputPath;

    [HorizontalGroup(0.5f)]
    public List<Texture> InputTextures;

    [HorizontalGroup, InlineEditor(InlineEditorModes.LargePreview)]
    public Texture Preview;

    [Button(ButtonSizes.Gigantic), GUIColor(0, 1, 0)]
    public void PerformSomeAction()
    {
        // 实现你的功能
    }
}