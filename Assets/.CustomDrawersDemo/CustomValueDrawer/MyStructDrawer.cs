using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;

public class MyStructDrawer : OdinValueDrawer<MyStruct>
{
    protected override void DrawPropertyLayout(GUIContent label)
    {
        // 获取绘制区域
        Rect rect = EditorGUILayout.GetControlRect();

        // 处理标签（在Odin中标签可能为null）
        if (label != null)
        {
            rect = EditorGUI.PrefixLabel(rect, label);
        }

        // 获取当前属性值
        MyStruct value = this.ValueEntry.SmartValue;

        // 设置标签宽度并绘制两个滑动条
        GUIHelper.PushLabelWidth(20);
        value.X = EditorGUI.Slider(rect.AlignLeft(rect.width * 0.5f), "X", value.X, 0, 1);
        value.Y = EditorGUI.Slider(rect.AlignRight(rect.width * 0.5f), "Y", value.Y, 0, 1);
        GUIHelper.PopLabelWidth();

        // 将修改后的值赋回给属性
        this.ValueEntry.SmartValue = value;
    }
}