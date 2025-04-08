using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MultiLinePropertyDemo : MonoBehaviour
{
    // Unity's TextArea and Multiline attributes and Odin's MultiLineProperty attribute
    // are all very similar.
    // 
    // TextArea specifies a minimum and maximum number of lines. It will display at least
    // the minimum number of lines, but will expand with its content up to the maximum
    // number of lines, and display a scrollbar past that.
    // 
    // Multiline and MultiLineProperty are given a precise number of lines to occupy and
    // will never contract or expand based on contents; instead they display a scrollbar
    // if the content does not fit into the given number of lines.
    // 
    // Finally, unlike Multiline, Odin's MultiLineProperty can be applied to any member
    // type including fields, properties, method arguments, types, and so on.

    [TextArea(4, 10)]
    public string UnityTextAreaField = "";

    [Multiline(10)]
    public string UnityMultilineField = "";

    [Title("Wide Multiline Text Field", bold: false)]
    [HideLabel]
    [MultiLineProperty(10)]
    public string WideMultilineTextField = "";

    [InfoBox("Odin supports properties, but Unity's own Multiline attribute only works on fields.")]
    [ShowInInspector]
    [MultiLineProperty(10)]
    public string OdinMultilineProperty { get; set; }
}
