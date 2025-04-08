using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class HideLabelDemo : MonoBehaviour
{
    [Title("Wide Colors")]
    [HideLabel]
    [ColorPalette("Fall")]
    public Color WideColor1;

    [HideLabel]
    [ColorPalette("Fall")]
    public Color WideColor2;

    [Title("Wide Vector")]
    [HideLabel]
    public Vector3 WideVector1;

    [HideLabel]
    public Vector4 WideVector2;

    [Title("Wide String")]
    [HideLabel]
    public string WideString;

    [Title("Wide Multiline Text Field")]
    [HideLabel]
    [MultiLineProperty]
    public string WideMultilineTextField = "";
}
