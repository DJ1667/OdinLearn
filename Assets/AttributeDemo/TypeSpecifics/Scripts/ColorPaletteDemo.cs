using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

public class ColorPaletteDemo : MonoBehaviour
{
    [ColorPalette]
    public Color ColorOptions; // 从调色板中选择颜色

    [ColorPalette("Underwater")]
    public Color UnderwaterColor; // 从调色板中的Underwater选择颜色

    [ColorPalette("My Palette")]
    public Color MyColor; // 创建自己的名为My Palette的调色板，并从其中选择颜色

    public string DynamicPaletteName = "Clovers"; // 指定调色板名称

    // The ColorPalette attribute supports both 
    // member references and attribute expressions.
    [ColorPalette("$DynamicPaletteName")]
    public Color DynamicPaletteColor; // 从动态指定的调色板中选择颜色

    [ColorPalette("Fall"), HideLabel]
    public Color WideColorPalette; //隐藏label使得显示区域更宽

    [ColorPalette("Clovers")]
    public Color[] ColorArray; // 颜色数据，每个元素从指定调色板中选择颜色

    // ------------------------------------
    // Color palettes can be accessed and modified from code.
    // Note that the color palettes will NOT automatically be included in your builds.
    // But you can easily fetch all color palettes via the ColorPaletteManager 
    // and include them in your game like so:
    // ------------------------------------

    //-------------------------------------
    // 可以直接获取所有颜色调色板的内容
    // ------------------------------------

    [FoldoutGroup("Color Palettes", expanded: false)]
    [ListDrawerSettings(IsReadOnly = true)]
    [PropertyOrder(9)]
    public List<ColorPalette> ColorPalettes; // 颜色调色板列表

    [Serializable]
    public class ColorPalette
    {
        [HideInInspector]
        public string Name;

        [LabelText("$Name")]
        [ListDrawerSettings(IsReadOnly = true, ShowFoldout = false)]
        public Color[] Colors;
    }

    [FoldoutGroup("Color Palettes"), Button(ButtonSizes.Large), GUIColor(0, 1, 0), PropertyOrder(8)]
    private void FetchColorPalettes()
    {
        this.ColorPalettes = Sirenix.OdinInspector.Editor.ColorPaletteManager.Instance.ColorPalettes
            .Select(x => new ColorPalette()
            {
                Name = x.Name,
                Colors = x.Colors.ToArray()
            })
            .ToList();
    }
}
