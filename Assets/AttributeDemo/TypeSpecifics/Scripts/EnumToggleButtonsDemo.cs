using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class EnumToggleButtonsDemo : MonoBehaviour
{
    [Title("Default")]
    public SomeBitmaskEnum DefaultEnumBitmask;
    public SomeBitmaskEnumNotFlags DefaultEnumBitmaskNotFlags;

    [Title("Standard Enum")]
    [EnumToggleButtons]
    public SomeEnum SomeEnumField; //以按钮的形式显示枚举值

    [EnumToggleButtons, HideLabel]
    public SomeEnum WideEnumField;

    [Title("Bitmask Enum")]
    [EnumToggleButtons]
    public SomeBitmaskEnum BitmaskEnumField;

    [EnumToggleButtons, HideLabel]
    public SomeBitmaskEnum EnumFieldWide;

    [Title("Icon Enum")]
    [EnumToggleButtons, HideLabel]
    public SomeEnumWithIcons EnumWithIcons; //以按钮的形式显示枚举值，并使用图标

    [EnumToggleButtons, HideLabel]
    public SomeEnumWithIconsAndNames EnumWithIconsAndNames; //以按钮的形式显示枚举值，并使用图标，使用标签显示枚举

    public enum SomeEnum
    {
        First, Second, Third, Fourth, AndSoOn
    }

    public enum SomeEnumWithIcons
    {
        [LabelText(SdfIconType.TextLeft)] TextLeft,
        [LabelText(SdfIconType.TextCenter)] TextCenter,
        [LabelText(SdfIconType.TextRight)] TextRight,
    }

    public enum SomeEnumWithIconsAndNames
    {
        [LabelText("Align Left", SdfIconType.TextLeft)] TextLeft,
        [LabelText("Align Center", SdfIconType.TextCenter)] TextCenter,
        [LabelText("Align Right", SdfIconType.TextRight)] TextRight,
    }

    [System.Flags] //允许枚举值通过按位操作符（如 |, &, ^）进行组合和分解,这对于表示一组可以同时选择多个选项的状态特别有用
    public enum SomeBitmaskEnum
    {
        A = 1 << 1,
        B = 1 << 2,
        C = 1 << 3,
        All = A | B | C
    }

    public enum SomeBitmaskEnumNotFlags
    {
        A = 1 << 1,
        B = 1 << 2,
        C = 1 << 3,
        All = A | B | C
    }
}
