using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class VerticalGroupDemo : MonoBehaviour
{
    [HorizontalGroup("Split")]
    [VerticalGroup("Split/Left")]
    public InfoMessageType First;

    [VerticalGroup("Split/Left")]
    public InfoMessageType Second;

    [HideLabel]
    [VerticalGroup("Split/Right")]
    public int A;

    [HideLabel]
    [VerticalGroup("Split/Right")]
    public int B;
}
