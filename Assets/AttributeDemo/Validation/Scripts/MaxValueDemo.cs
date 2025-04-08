using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MaxValueDemo : MonoBehaviour
{
    // Ints
    [Title("Int")]
    [MinValue(0)]
    public int IntMinValue0;

    [MaxValue(0)]
    public int IntMaxValue0;

    // Floats
    [Title("Float")]
    [MinValue(0)]
    public float FloatMinValue0;

    [MaxValue(0)]
    public float FloatMaxValue0;

    // Vectors
    [Title("Vectors")]
    [MinValue(0)]
    public Vector3 Vector3MinValue0;

    [MaxValue(0)]
    public Vector3 Vector3MaxValue0;

    void Awake()
    {
        Debug.Log($"IntMinValue0: {IntMinValue0}");
        Debug.Log($"IntMaxValue0: {IntMaxValue0}");
        Debug.Log($"FloatMinValue0: {FloatMinValue0}");
        Debug.Log($"FloatMaxValue0: {FloatMaxValue0}");
        Debug.Log($"Vector3MinValue0: {Vector3MinValue0}");
        Debug.Log($"Vector3MaxValue0: {Vector3MaxValue0}");
    }
}
