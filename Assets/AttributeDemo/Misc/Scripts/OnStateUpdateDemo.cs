using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class OnStateUpdateDemo : MonoBehaviour
{
    public List<string> list;

    [OnStateUpdate("@#(list).State.Expanded = $value")]
    public bool ExpandList;
}
