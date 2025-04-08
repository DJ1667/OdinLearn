using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using UnityEngine;
using UnityEditor;

public class HealthBarAttributeDrawer : OdinAttributeDrawer<HealthBarAttribute, float>
{
    protected override void DrawPropertyLayout(GUIContent label)
    {
        // 调用下一个绘制器,用于绘制浮点数字段
        this.CallNextDrawer(label);

        // 获取一个用于绘制血条的矩形区域
        Rect rect = EditorGUILayout.GetControlRect();

        // 使用矩形区域绘制血条
        //计算血条的比例，并限制在[0-1]之间
        float width = Mathf.Clamp01(this.ValueEntry.SmartValue / this.Attribute.MaxHealth);
        //绘制了一个黑色半透明的背景矩形
        SirenixEditorGUI.DrawSolidRect(rect, new Color(0f, 0f, 0f, 0.3f), false);
        //在背景上绘制了一个红色的矩形，其宽度根据计算出的比例进行了缩放
        SirenixEditorGUI.DrawSolidRect(rect.SetWidth(rect.width * width), Color.red, false);
        //最后给整个矩形绘制了一个边框
        SirenixEditorGUI.DrawBorders(rect, 1);
    }
}