using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector.Editor;
using UnityEngine;

public class CustomDrawers : MonoBehaviour
{
    [HealthBar(100)]
    public float Health;

    public MyStruct myStruct;

    [ColoredFoldoutGroup("MyGroup", 1, 0, 0)]
    public int A;

    [ColoredFoldoutGroup("MyGroup")]
    public int B;
    public int C;
}
