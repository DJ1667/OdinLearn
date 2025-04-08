using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class HorizontalGroupDemo : MonoBehaviour
{
    // The width can either be specified as percentage or pixels.
    // All values between 0 and 1 will be treated as a percentage.
    // If the width is 0 the column will be automatically sized.

    // Auto width
    [HorizontalGroup]
    public SomeFieldType Left1;

    [HorizontalGroup]
    public SomeFieldType Right1;

    // Margins
    [HorizontalGroup("row2", MarginRight = 0.4f)]
    public SomeFieldType Left2; //右侧边距  介于0和1之间的值将被视为百分比，0=忽略，否则为像素

    [HorizontalGroup("row2")]
    public SomeFieldType Right2;


    // Custom width:
    [HorizontalGroup("row1", Width = 0.25f)] // 25 %
    public SomeFieldType Left3;

    [HorizontalGroup("row1", Width = 150)] // 150 px
    public SomeFieldType Center3;

    [HorizontalGroup("row1")] // Auto / expand
    public SomeFieldType Right3;


    // Gap Size
    [HorizontalGroup("row3", Gap = 10)]
    public SomeFieldType Left4; // 列之间的间距

    [HorizontalGroup("row3")]
    public SomeFieldType Center4;

    [HorizontalGroup("row3")] // Auto / expand
    public SomeFieldType Right4;


    // Title
    [HorizontalGroup("row4", Title = "Horizontal Group Title")]
    public SomeFieldType Left5;

    [HorizontalGroup("row4")]
    public SomeFieldType Center5;

    [HorizontalGroup("row4")]
    public SomeFieldType Right5;

    [HideLabel, Serializable]
    public struct SomeFieldType
    {
        [LabelText("@$property.Parent.NiceName")] // 显示父属性的名称
        [ListDrawerSettings(ShowIndexLabels = true)] // 显示索引标签
        public float[] x;
    }

    [Space(50)]
    [TitleGroup("Multiple Stacked Boxes")]
    [HorizontalGroup("Multiple Stacked Boxes/Split")]
    [VerticalGroup("Multiple Stacked Boxes/Split/Left")]
    [BoxGroup("Multiple Stacked Boxes/Split/Left/Box A")]
    public int BoxA;

    [BoxGroup("Multiple Stacked Boxes/Split/Left/Box B")]
    public int BoxB;

    [VerticalGroup("Multiple Stacked Boxes/Split/Right")]
    [BoxGroup("Multiple Stacked Boxes/Split/Right/Box C")]
    public int BoxC, BoxD, BoxE;
}
