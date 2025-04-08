using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ToggleLeftDemo : MonoBehaviour
{
    [InfoBox("Draws the toggle button before the label for a bool property.")]
    [ToggleLeft]
    public bool LeftToggled;

    [EnableIf("LeftToggled")] //如果LeftToggled为true，则A属性可被编辑
    public int A;

    [EnableIf("LeftToggled")]
    public bool B;

    [EnableIf("LeftToggled")]
    public bool C;
}
