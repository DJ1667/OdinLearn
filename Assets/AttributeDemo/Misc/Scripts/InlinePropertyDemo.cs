using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class InlinePropertyDemo : MonoBehaviour
{
    public Vector3 Vector3;
    public Vector3IntNoInline MyVector3IntNotInline;

    public Vector3Int MyVector3Int;

    [InlineProperty(LabelWidth = 13)]
    public Vector2Int MyVector2Int;

    [Serializable]
    [InlineProperty(LabelWidth = 13)]
    public struct Vector3Int
    {
        [HorizontalGroup]
        public int X;

        [HorizontalGroup]
        public int Y;

        [HorizontalGroup]
        public int Z;
    }

    [Serializable]
    public struct Vector2Int
    {
        [HorizontalGroup]
        public int X;

        [HorizontalGroup]
        public int Y;
    }

    [Serializable]
    public struct Vector3IntNoInline
    {
        // [HorizontalGroup]
        public int X;
        // [HorizontalGroup]
        public int Y;
        // [HorizontalGroup]
        public int Z;
    }
}
