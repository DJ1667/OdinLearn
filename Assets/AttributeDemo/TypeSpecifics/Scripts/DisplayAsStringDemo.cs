using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class DisplayAsStringDemo : MonoBehaviour
{
    [InfoBox(
        "Instead of disabling values in the inspector in order to show some information or debug a value. " +
        "You can use DisplayAsString to show the value as text, instead of showing it in a disabled drawer")]
    [DisplayAsString]
    public Color SomeColor; // 将颜色显示为字符串

    [DisplayAsString]
    public GameObject SomeGameObject;

    [DisplayAsString]
    public GameObject SomeGameObjectNoValue;

    [BoxGroup("SomeBox")]
    [HideLabel]
    [DisplayAsString]
    public string SomeText = "Lorem Ipsum";
    [BoxGroup("SomeBox")]
    [DisplayAsString]
    public int SomeInt = 123;

    [InfoBox("The DisplayAsString attribute can also be configured to enable or disable overflowing to multiple lines.")]
    [HideLabel]
    [DisplayAsString]
    public string Overflow = "A very very very very very very very very very long string that has been configured to overflow."; // 默认为溢出

    [HideLabel]
    [DisplayAsString(false)]
    public string DisplayAllOfIt = "A very very very very very very very very long string that has been configured to not overflow."; // 配置为不溢出

    [InfoBox("Additionally, you can also configure the string's alignment, font size, and whether it should support rich text or not.")]
    [DisplayAsString(false, 20, TextAlignment.Center, true)]
    public string CustomFontSizeAlignmentAndRichText = "This string is <b><color=#FF5555><i>super</i> <size=24>big</size></color></b> and centered."; // 配置字体大小、对齐方式和是否支持富文本
}
