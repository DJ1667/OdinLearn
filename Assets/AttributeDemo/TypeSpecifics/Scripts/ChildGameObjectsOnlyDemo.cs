using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ChildGameObjectsOnlyDemo : MonoBehaviour
{
    [ChildGameObjectsOnly]
    public Transform ChildOrSelfTransform; // 选择子对象或自身

    [ChildGameObjectsOnly]
    public GameObject ChildGameObject; // 选择子对象或自身

    [ChildGameObjectsOnly(IncludeSelf = false)]
    public Light[] Lights; // 选择子对象或自身，不包括自身
}
