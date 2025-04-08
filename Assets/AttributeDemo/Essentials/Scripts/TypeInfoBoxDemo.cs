using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class TypeInfoBoxDemo : MonoBehaviour
{
    public MyType MyObject = new MyType();

    [InfoBox("Click the pen icon to open a new inspector for the Scripty object.")]
    [InlineEditor]
    public MyScriptyScriptableObjectDemo Scripty;

    [Serializable]
    [TypeInfoBox("The TypeInfoBox attribute can be put on type definitions and will result in an InfoBox being drawn at the top of a property.")]
    public class MyType //TypeInfoBox属性可以放在类型定义上，将导致在属性顶部绘制InfoBox。
    {
        public int Value;
    }

}
