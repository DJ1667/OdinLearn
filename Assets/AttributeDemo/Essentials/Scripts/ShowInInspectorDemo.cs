using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

public class ShowInInspectorDemo : MonoBehaviour
{
    [ShowInInspector]
    [PropertyOrder(-2)]
    private int myPrivateInt;

    [ShowInInspector]
    [PropertyOrder(-2)]
    public int MyPropertyInt { get; set; }

    [ShowInInspector]
    [PropertyOrder(-2)]
    public int ReadOnlyProperty
    {
        get { return this.myPrivateInt; }
    }

    [ShowInInspector]
    [PropertyOrder(-2)]
    public static bool StaticProperty { get; set; }

    [Space(30)]

    [SerializeField]
    [HideInInspector]
    [PropertyOrder(-1)]
    private int evenNumber;

    [PropertySpace(30)]
    [ShowInInspector]
    [PropertyOrder(-1)]
    public int EvenNumber
    {
        get { return this.evenNumber; }
        set { this.evenNumber = value - (value % 2); }
    }

    [Space(30)]

    [ShowInInspector]
    [PropertyOrder(1)]
    public static List<MySomeStruct> SomeStaticField;

    [ShowInInspector, PropertyRange(0, 0.1f)]
    [PropertyOrder(2)]
    public static float FixedDeltaTime
    {
        get { return Time.fixedDeltaTime; }
        set { Time.fixedDeltaTime = value; }
    }

    [Serializable]
    public struct MySomeStruct
    {
        [HideLabel, PreviewField(45)]
        [HorizontalGroup("Split", width: 45)]
        public Texture2D Icon;

        [FoldoutGroup("Split/$Icon")]
        [HorizontalGroup("Split/$Icon/Properties", LabelWidth = 40)]
        public int Foo;

        [HorizontalGroup("Split/$Icon/Properties")]
        public int Bar;
    }

    [Button(ButtonSizes.Large), PropertyOrder(1)]
    public static void AddToList()
    {
        int count = SomeStaticField.Count + 1;
        SomeStaticField.Capacity = count;
        while (SomeStaticField.Count < count)
        {
            SomeStaticField.Add(new MySomeStruct() { Icon = ExampleHelper.GetTexture() });
        }
    }

    // [OnInspectorInit]
    // private static void CreateData()
    // {
    //     SomeStaticField = new List<MySomeStruct>()
    // {
    //     new MySomeStruct(){ Icon = ExampleHelper.GetTexture() },
    //     new MySomeStruct(){ Icon = ExampleHelper.GetTexture() },
    //     new MySomeStruct(){ Icon = ExampleHelper.GetTexture() },
    // };
    // }

    void Awake()
    {
        Debug.Log("myPrivateInt: " + myPrivateInt);
    }

}
