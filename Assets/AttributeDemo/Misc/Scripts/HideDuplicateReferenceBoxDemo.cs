using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using UnityEngine;

public class HideDuplicateReferenceBoxDemo : MonoBehaviour
{
    [PropertyOrder(1)]
    public ReferenceTypeClass firstObject;

    [PropertyOrder(3)]
    public ReferenceTypeClass withReferenceBox;

    [PropertyOrder(5)]
    [HideDuplicateReferenceBox]
    public ReferenceTypeClass withoutReferenceBox;

    [OnInspectorInit]
    public void CreateData()
    {
        this.firstObject = new ReferenceTypeClass();
        this.withReferenceBox = this.firstObject;
        this.withoutReferenceBox = this.firstObject;
        this.firstObject.recursiveReference = this.firstObject;
    }

    [Serializable]
    public class ReferenceTypeClass
    {
        [HideDuplicateReferenceBox]
        public ReferenceTypeClass recursiveReference;

        [OnInspectorGUI, PropertyOrder(-1)]
        private void MessageBox()
        {
            SirenixEditorGUI.WarningMessageBox("递归绘制的引用将始终显示引用框，以防止无限深度的绘制循环。");
        }
    }

    [OnInspectorGUI, PropertyOrder(0)]
    private void MessageBox1()
    {
        SirenixEditorGUI.Title("第一个引用将始终正常绘制", null, TextAlignment.Left, true);
    }

    [OnInspectorGUI, PropertyOrder(2)]
    private void MessageBox2()
    {
        GUILayout.Space(20);
        SirenixEditorGUI.Title("所有后续引用都将被包装在一个引用框中", null, TextAlignment.Left, true);
    }

    [OnInspectorGUI, PropertyOrder(4)]
    private void MessageBox3()
    {
        GUILayout.Space(20);
        SirenixEditorGUI.Title("使用 [HideDuplicateReferenceBox] 属性，这个框被隐藏了", null, TextAlignment.Left, true);
    }
}
