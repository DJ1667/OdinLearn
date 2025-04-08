using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class LabelWidthDemo : MonoBehaviour
{
    public int DefaultWidth;

    [LabelWidth(50)]
    public int Thin;

    [LabelWidth(250)]
    public int Wide;
}
