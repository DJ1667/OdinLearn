using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class TestValidator : MonoBehaviour, ISelfValidator
{
    public string Id;

    public string Name;

    // [ForbiddenWord("V1", "V2", "VV")]
    public string SomeString;

    public GameObject Prefab;

    public void Validate(SelfValidationResult result)
    {
        if (Prefab == null)
        {
            result.AddError("Prefab must not be null!");
        }
    }
}
