using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;

public class CustomValueDrawerDemo : MonoBehaviour
{
    public float From = 2, To = 7;

    [CustomValueDrawer("MyCustomDrawerStatic")]
    public float CustomDrawerStatic; //直接指定值

    [CustomValueDrawer("MyCustomDrawerInstance")]
    public float CustomDrawerInstance; //使用本实例的From和To

    [CustomValueDrawer("MyCustomDrawerAppendRange")]
    public float AppendRange; //直接显示值的同时显示一个滑动条

    [CustomValueDrawer("MyCustomDrawerArrayNoLabel")]
    public float[] CustomDrawerArrayNoLabel = new float[] { 3f, 5f, 6f }; //不显示标签,GUIContent label其实就是字段名

    private static float MyCustomDrawerStatic(float value, GUIContent label)
    {
        return EditorGUILayout.Slider(label, value, 0f, 10f);
    }

    private static float MyCustomDrawerStatic_AddBtn(float value, GUIContent label)
    {
        SirenixEditorGUI.BeginBox();

        var result = EditorGUILayout.Slider(label, value, 0f, 10f);
        if (GUILayout.Button("Add 1"))
        {
            result += 1;
        }

        SirenixEditorGUI.EndBox();

        return result;
    }

    private float MyCustomDrawerInstance(float value, GUIContent label)
    {
        return EditorGUILayout.Slider(label, value, this.From, this.To);
    }

    private float MyCustomDrawerAppendRange(float value, GUIContent label, Func<GUIContent, bool> callNextDrawer)
    {
        SirenixEditorGUI.BeginBox();
        callNextDrawer(label);
        var result = EditorGUILayout.Slider(value, this.From, this.To);
        SirenixEditorGUI.EndBox();
        return result;
    }

    private float MyCustomDrawerArrayNoLabel(float value)
    {
        return EditorGUILayout.Slider(value, this.From, this.To);
    }
}
