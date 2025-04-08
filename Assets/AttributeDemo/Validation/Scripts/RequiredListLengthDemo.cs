using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class RequiredListLengthDemo : MonoBehaviour
{
    [RequiredListLength(10)]
    public int[] fixedLength; //固定长度

    [RequiredListLength(1, null)]
    public int[] minLength; //最小长度

    [RequiredListLength(null, 10, PrefabKind = PrefabKind.InstanceInScene)]
    public List<int> maxLength; //最大长度

    [RequiredListLength(3, 10)]
    public List<int> minAndMaxLength; //最小和最大长度

    public int SomeNumber;

    [RequiredListLength("@this.SomeNumber")]
    public List<GameObject> matchLengthOfOther; //动态固定长度

    [RequiredListLength("@this.SomeNumber", null)]
    public int[] minLengthExpression; //动态最小长度

    [RequiredListLength(null, "@this.SomeNumber")]
    public List<int> maxLengthExpression; //动态最大长度

    void Awake()
    {
        Debug.Log("maxLength: " + maxLength.Count);
    }
}
