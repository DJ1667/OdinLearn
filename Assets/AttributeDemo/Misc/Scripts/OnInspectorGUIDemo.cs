using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class OnInspectorGUIDemo : MonoBehaviour
{
    [OnInspectorInit("@Texture = Sirenix.Utilities.Editor.EditorIcons.OdinInspectorLogo")]
    [OnInspectorGUI("DrawPreview", append: true)]
    public Texture2D Texture;

    private void DrawPreview()
    {
        if (this.Texture == null) return;

        GUILayout.BeginVertical(GUI.skin.box);
        GUILayout.Label(this.Texture);
        GUILayout.EndVertical();
    }

    [OnInspectorGUI] // 用在方法上时直接调用这个方法
    private void OnInspectorGUI()
    {
        UnityEditor.EditorGUILayout.HelpBox("OnInspectorGUI 可以同时用于方法和属性", UnityEditor.MessageType.Info);
    }
}
