using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class RequiredDemo : MonoBehaviour
{
    [Required]
    public GameObject MyGameObject;

    [Required("Custom error message.")]
    public Rigidbody MyRigidbody;

    [InfoBox("Use $ to indicate a member string as message.")]
    [Required("$DynamicMessage")]
    public GameObject GameObject;

    public string DynamicMessage = "Dynamic error message";
}
