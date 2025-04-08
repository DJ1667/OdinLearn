using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEngine;

public class ColoredFoldoutGroupAttributeDrawer : OdinGroupDrawer<ColoredFoldoutGroupAttribute>
{
    // 持久化的折叠状态
    private LocalPersistentContext<bool> isExpanded;

    protected override void Initialize()
    {
        // 获取持久化的折叠状态，即使Unity重启也能保持
        this.isExpanded = this.GetPersistentValue<bool>(
            "ColoredFoldoutGroupAttributeDrawer.isExpanded",
            GeneralDrawerConfig.Instance.ExpandFoldoutByDefault);
    }

    protected override void DrawPropertyLayout(GUIContent label)
    {
        // 设置组的颜色
        GUIHelper.PushColor(new Color(this.Attribute.R, this.Attribute.G, this.Attribute.B, this.Attribute.A));
        SirenixEditorGUI.BeginBox();
        SirenixEditorGUI.BeginBoxHeader();
        GUIHelper.PopColor();

        // 绘制折叠控件
        this.isExpanded.Value = SirenixEditorGUI.Foldout(this.isExpanded.Value, label);
        SirenixEditorGUI.EndBoxHeader();

        // 根据折叠状态显示子属性，带有动画效果
        if (SirenixEditorGUI.BeginFadeGroup(this, this.isExpanded.Value))
        {
            for (int i = 0; i < this.Property.Children.Count; i++)
            {
                this.Property.Children[i].Draw();
            }
        }

        SirenixEditorGUI.EndFadeGroup();
        SirenixEditorGUI.EndBox();
    }
}