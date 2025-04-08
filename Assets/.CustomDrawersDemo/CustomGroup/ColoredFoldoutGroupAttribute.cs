using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ColoredFoldoutGroupAttribute : PropertyGroupAttribute
{
    public float R, G, B, A;

    // 只接受路径的构造函数，允许在同一路径上的其他属性共享颜色设置
    public ColoredFoldoutGroupAttribute(string path)
        : base(path)
    {
    }

    // 接受路径和颜色值的构造函数
    public ColoredFoldoutGroupAttribute(string path, float r, float g, float b, float a = 1f)
        : base(path)
    {
        this.R = r;
        this.G = g;
        this.B = b;
        this.A = a;
    }

    // 用于合并具有相同路径的Group属性
    protected override void CombineValuesWith(PropertyGroupAttribute other)
    {
        var otherAttr = (ColoredFoldoutGroupAttribute)other;

        this.R = Math.Max(otherAttr.R, this.R);
        this.G = Math.Max(otherAttr.G, this.G);
        this.B = Math.Max(otherAttr.B, this.B);
        this.A = Math.Max(otherAttr.A, this.A);
    }
}
