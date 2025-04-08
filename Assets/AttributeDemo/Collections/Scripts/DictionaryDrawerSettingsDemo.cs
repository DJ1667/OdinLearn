using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

public class DictionaryDrawerSettingsDemo : SerializedMonoBehaviour
{
    [InfoBox("为了序列化字典，我们只需要从 SerializedMonoBehaviour 继承我们的类。")]
    public Dictionary<int, Material> IntMaterialLookup;

    public Dictionary<string, string> StringStringDictionary;

    [DictionaryDrawerSettings(KeyLabel = "Custom Key Name", ValueLabel = "Custom Value Label")]
    public Dictionary<SomeEnum, MyCustomType> CustomLabels = new Dictionary<SomeEnum, MyCustomType>()
    {
        { SomeEnum.First, new MyCustomType() },
        { SomeEnum.Second, new MyCustomType() },
    };

    [DictionaryDrawerSettings(DisplayMode = DictionaryDisplayOptions.ExpandedFoldout)]
    public Dictionary<string, List<int>> StringListDictionary = new Dictionary<string, List<int>>()
    {
        { "Numbers", new List<int>(){ 1, 2, 3, 4, } },
    };

    [DictionaryDrawerSettings(DisplayMode = DictionaryDisplayOptions.Foldout)]
    public Dictionary<SomeEnum, MyCustomType> EnumObjectLookup = new Dictionary<SomeEnum, MyCustomType>()
    {
        { SomeEnum.Third, new MyCustomType() },
        { SomeEnum.Fourth, new MyCustomType() },
    };

    [InlineProperty(LabelWidth = 90)]
    public struct MyCustomType
    {
        public int SomeMember;
        public GameObject SomePrefab;
    }

    public enum SomeEnum
    {
        First, Second, Third, Fourth, AndSoOn
    }


    [OnInspectorInit]
    private void CreateData()
    {
        IntMaterialLookup = new Dictionary<int, Material>()
    {
        { 1, ExampleHelper.GetMaterial() },
        { 7, ExampleHelper.GetMaterial() },
    };

        StringStringDictionary = new Dictionary<string, string>()
    {
        { "One", ExampleHelper.GetString() },
        { "Seven", ExampleHelper.GetString() },
    };
    }
}
