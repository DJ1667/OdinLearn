using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ButtonDemo3 : MonoBehaviour
{
    [Button(SdfIconType.Dice1Fill, IconAlignment.LeftOfText)]
    private void IconButtonLeftOfText() { }

    [Button(SdfIconType.Dice2Fill, IconAlignment.RightOfText)]
    private void IconButtonRightOfText() { }

    [Button(SdfIconType.Dice3Fill, IconAlignment.LeftEdge)]
    private void IconButtonLeftEdge() { }

    [Button(SdfIconType.Dice4Fill, IconAlignment.RightEdge)]
    private void IconButtonRightEdge() { }

    [Button(SdfIconType.Dice5Fill, IconAlignment.RightEdge, Stretch = false)]
    private void DontStretch() { }

    [Button(SdfIconType.Dice5Fill, IconAlignment.RightEdge, Stretch = false, ButtonAlignment = 1f)]
    private void DontStretchAndAlign() { }
}
