using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using Sirenix.Serialization;
using UnityEngine;

public class SearchableDemo : SerializedMonoBehaviour
{
    [Searchable] //修饰字段
    public List<Perk> Perks = new List<Perk>()
    {
        new Perk()
        {
            Name = "Old Sage",
            Effects = new List<Effect>()
            {
                new Effect() { Skill = Skill.Wisdom, Value = 2, },
                new Effect() { Skill = Skill.Intelligence, Value = 1, },
                new Effect() { Skill = Skill.Strength, Value = -2 },
            },
        },
        new Perk()
        {
            Name = "Hardened Criminal",
            Effects = new List<Effect>()
            {
                new Effect() { Skill = Skill.Dexterity, Value = 2, },
                new Effect() { Skill = Skill.Strength, Value = 1, },
                new Effect() { Skill = Skill.Charisma, Value = -2 },
            },
        },
        new Perk()
        {
            Name = "Born Leader",
            Effects = new List<Effect>()
            {
                new Effect() { Skill = Skill.Charisma, Value = 2, },
                new Effect() { Skill = Skill.Intelligence, Value = -3 },
            },
        },
        new Perk()
        {
            Name = "Village Idiot",
            Effects = new List<Effect>()
            {
                new Effect() { Skill = Skill.Charisma, Value = 4, },
                new Effect() { Skill = Skill.Constitution, Value = 2, },
                new Effect() { Skill = Skill.Intelligence, Value = -3 },
                new Effect() { Skill = Skill.Wisdom, Value = -3 },
            },
        },
    };

    [Serializable]
    public class Perk
    {
        public string Name;

        [TableList]
        public List<Effect> Effects;
    }

    [Serializable]
    public class Effect
    {
        public Skill Skill;
        public float Value;
    }

    public enum Skill
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma,
    }

    [Space(50)]
    [Searchable] //修饰类
    public ExampleClass searchableClass = new ExampleClass();

    [Searchable]
    public List<ExampleStruct> searchableList = new List<ExampleStruct>(Enumerable.Range(1, 10).Select(i => new ExampleStruct(i)));

    [Searchable(FilterOptions = SearchFilterOptions.ISearchFilterableInterface)]
    public List<FilterableBySquareStruct> customFiltering = new List<FilterableBySquareStruct>(Enumerable.Range(1, 10).Select(i => new FilterableBySquareStruct(i)));

    [Serializable]
    public class ExampleClass
    {
        public string SomeString = "Saehrimnir is a tasty delicacy";
        public int SomeInt = 13579;

        public DataContainer DataContainerOne = new DataContainer() { Name = "Example Data Set One" };
        public DataContainer DataContainerTwo = new DataContainer() { Name = "Example Data Set Two" };
    }

    [Serializable, Searchable] // You can also apply it on a type like this, and it will become searchable wherever it appears
    public class DataContainer
    {
        public string Name;
        public List<ExampleStruct> Data = new List<ExampleStruct>(Enumerable.Range(1, 10).Select(i => new ExampleStruct(i)));
    }

    [Serializable]
    public struct FilterableBySquareStruct : ISearchFilterable
    {
        public int Number;

        [ShowInInspector, DisplayAsString, EnableGUI]
        public int Square { get { return this.Number * this.Number; } }

        public FilterableBySquareStruct(int nr)
        {
            this.Number = nr;
        }

        public bool IsMatch(string searchString)
        {
            return searchString.Contains(Square.ToString());
        }
    }

    [Serializable]
    public struct ExampleStruct
    {
        public string Name;
        public int Number;
        public ExampleEnum Enum;

        public ExampleStruct(int nr) : this()
        {
            this.Name = "Element " + nr;
            this.Number = nr;

            this.Enum = (ExampleEnum)ExampleHelper.RandomInt(0, 5);
        }
    }

    public enum ExampleEnum
    {
        One, Two, Three, Four, Five
    }

    [Space(50)]

    [Searchable(Recursive = false)]
    public Dictionary<string, string> searchableDictionary = new Dictionary<string, string>()
    {
        { "Key1", "Value1" },
        { "Key2", "Value2" },
        { "Key3", "Value3" },
    };
    
}
