using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class LabelTextDemo : MonoBehaviour
{
    [LabelText("1")]
    public int MyInt1 = 1;

    [LabelText("2")]
    public int MyInt2 = 12;

    [LabelText("3")]
    public int MyInt3 = 123;

    [InfoBox("使用 $ 来引用成员字符串。")]
    [LabelText("$MyInt3")]
    public string LabelText = "The label is taken from the number 3 above";

    [InfoBox("使用 @ 来执行表达式。")]
    [LabelText("@DateTime.Now.ToString(\"HH:mm:ss\")")]
    public string DateTimeLabel;

    [LabelText("Test", SdfIconType.HeartFill)]
    public int LabelIcon1 = 123;

    [LabelText("", SdfIconType.HeartFill)]
    public int LabelIcon2 = 123;
}
