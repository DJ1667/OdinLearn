using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class SuffixLabelDemo : MonoBehaviour
{
    [SuffixLabel("Prefab")]
    public GameObject GameObject;

    [Space(15)]
    [InfoBox(
        "使用 Overlay 属性，后缀标签将绘制在属性里面而不是后方。\n" +
        "使用这个可以获得整洁的内联外观。")]
    [SuffixLabel("ms", Overlay = true)]
    public float Speed;

    [SuffixLabel("radians", Overlay = true)]
    public float Angle;

    [Space(15)]
    [InfoBox("Suffix 特性也支持通过使用 $ 来引用成员字符串字段、属性或方法。")]
    [SuffixLabel("$Suffix", Overlay = true)]
    public string Suffix = "Dynamic suffix label";

    [InfoBox("Suffix 特性也支持使用 @ 来编写表达式。")]
    [SuffixLabel("@DateTime.Now.ToString(\"HH:mm:ss\")", true)]
    public string Expression;

    [SuffixLabel("Suffix with icon", SdfIconType.HeartFill)]
    public string IconAndText1;

    [SuffixLabel(SdfIconType.HeartFill)]
    public string OnlyIcon1;

    [SuffixLabel("Suffix with icon", SdfIconType.HeartFill, Overlay = true)]
    public string IconAndText2;

    [SuffixLabel(SdfIconType.HeartFill, Overlay = true)]
    public string OnlyIcon2;
}
