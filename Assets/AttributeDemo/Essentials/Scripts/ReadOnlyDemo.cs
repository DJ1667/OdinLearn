using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ReadOnlyDemo : MonoBehaviour
{
    [ReadOnly]
    public string MyString = "This is displayed as text";

    [ReadOnly]
    public int MyInt = 9001;

    [ReadOnly]
    public int[] MyIntList = new int[] { 1, 2, 3, 4, 5, 6, 7, };
}
