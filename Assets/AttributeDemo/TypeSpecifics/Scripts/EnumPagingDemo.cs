using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class EnumPagingDemo : MonoBehaviour
{
    [EnumPaging]
    public SomeEnum SomeEnumField;

    public enum SomeEnum
    {
        A, B, C
    }
}
