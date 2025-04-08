using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MyInlineDemoScriptableObject : ScriptableObject
{
    [ShowInInlineEditors]
    public string ShownInInlineEditor; // 显示在InlineEditor中。即使不加这个特性，默认也是显示的

    [HideInInlineEditors]
    public string HiddenInInlineEditor; // 隐藏在InlineEditor中
}
