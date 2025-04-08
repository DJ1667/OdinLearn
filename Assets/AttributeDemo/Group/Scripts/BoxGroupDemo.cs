using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class BoxGroupDemo : MonoBehaviour
{
    // Box with a title.
    [BoxGroup("Some Title")]
    public string A;

    [BoxGroup("Some Title")]
    public string B;

    // Box with a centered title.
    [BoxGroup("Centered Title", centerLabel: true)]
    public string C;

    [BoxGroup("Centered Title")]
    public string D;

    // Box with a title received from a field.
    [BoxGroup("$G")]
    public string E = "Dynamic box title 2";

    [BoxGroup("$G")]
    public string F;

    // No title
    [BoxGroup]
    public string G;

    [BoxGroup]
    public string H;

    // A named box group without a title.
    [BoxGroup("NoTitle", false)]
    public string I;

    [BoxGroup("NoTitle")]
    public string J;

    [BoxGroup("A Struct In A Box"), HideLabel]
    public SomeStruct BoxedStruct; //使结构体显示在盒子里

    public SomeStruct DefaultStruct;

    [Serializable]
    public struct SomeStruct
    {
        public int One;
        public int Two;
        public int Three;
    }
}
