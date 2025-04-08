using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class OnInspectorDisposeDemo : MonoBehaviour
{
    [OnInspectorDispose("@UnityEngine.Debug.Log(\"Dispose event invoked!\")")]
    [ShowInInspector, InfoBox("当您更改此字段的类型或将其设置为null时，之前的属性设置将被丢弃。取消选择此示例时，属性设置也将被丢弃。"), DisplayAsString]
    public BaseClass PolymorphicField;

    public abstract class BaseClass { public override string ToString() { return this.GetType().Name; } }
    public class A : BaseClass { }
    public class B : BaseClass { }
    public class C : BaseClass { }
}
