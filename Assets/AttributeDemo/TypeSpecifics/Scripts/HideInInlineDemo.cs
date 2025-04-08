using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

public class HideInInlineDemo : MonoBehaviour
{
    [InfoBox("Click the pen icon to open a new inspector window for the InlineObject too see the differences these attributes make.")]
    [InlineEditor(Expanded = true)]
    public MyInlineDemoScriptableObject InlineObject; //可以将这个Object的属性在InlineEditor中显示或隐藏
}