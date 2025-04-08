using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ToggleDemo : MonoBehaviour
{
    [Toggle("Enabled")]
    public MyToggleable Toggler = new MyToggleable(); //在对象上使用Toggle属性

    public ToggleableClass Toggleable = new ToggleableClass();

    [Toggle("Enabled")]
    public MyStruct Struct = new MyStruct();

    [Serializable]
    public struct MyStruct
    {
        public bool Enabled;
        public int MyValue;
    }

    [Serializable]
    public class MyToggleable
    {
        public bool Enabled;
        public int MyValue;
    }

    // You can also use the Toggle attribute directly on a class definition.
    [Serializable, Toggle("Enabled")] //可以直接在类上使用Toggle属性
    public class ToggleableClass
    {
        public bool Enabled;
        public string Text;
    }
}
