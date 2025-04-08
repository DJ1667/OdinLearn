using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

//这里如果使用 MonoBehaviour 那么MyCustomReferenceType不会被序列化，不会在Inspector中显示
//如果想要MyCustomReferenceType在MonoBehaviour中被序列化，需要给MyCustomReferenceType添加[Serializable],
//但是HideReferenceObjectPicker只支持非Unity的序列化对象，所以这里使用SerializedMonoBehaviour
public class HideReferenceObjectPickerDemo : SerializedMonoBehaviour // MonoBehaviour
{
    [Title("Hidden Object Pickers")]
    [HideReferenceObjectPicker]
    public MyCustomReferenceType OdinSerializedProperty1 = new MyCustomReferenceType();

    [HideReferenceObjectPicker]
    public MyCustomReferenceType OdinSerializedProperty2 = new MyCustomReferenceType();

    [Title("Shown Object Pickers")]
    public MyCustomReferenceType OdinSerializedProperty3 = new MyCustomReferenceType();

    public MyCustomReferenceType OdinSerializedProperty4 = new MyCustomReferenceType();

    // Protip: You can also put the HideInInspector attribute on the class definition itself to hide it globally for all members.
    // [HideReferenceObjectPicker]
    public class MyCustomReferenceType
    {
        public int A;
        public int B;
        public int C;
    }
}
