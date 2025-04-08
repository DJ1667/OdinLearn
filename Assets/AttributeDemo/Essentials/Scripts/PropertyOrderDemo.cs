using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class PropertyOrderDemo : MonoBehaviour
{
    [PropertyOrder(1)]
    public int Second;

    [InfoBox("PropertyOrder is used to change the order of properties in the inspector.")]
    [PropertyOrder(-1)]
    public int First;
}
