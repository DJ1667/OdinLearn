using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

public class TableListDemo : MonoBehaviour
{
    [TableList(ShowIndexLabels = true)] //显示索引标签
    public List<SomeCustomClass> TableListWithIndexLabels = new List<SomeCustomClass>()
    {
        new SomeCustomClass(),
        new SomeCustomClass(),
    };

    [TableList(DrawScrollView = true, MaxScrollViewHeight = 200, MinScrollViewHeight = 100)] //设置滚动视图的高度,超过这个高度就会显示滚动条
    public List<SomeCustomClass> MinMaxScrollViewTable = new List<SomeCustomClass>()
    {
        new SomeCustomClass(),
        new SomeCustomClass(),
    };

    [TableList(AlwaysExpanded = true, DrawScrollView = false)] //设置总是展开,不显示滚动条
    public List<SomeCustomClass> AlwaysExpandedTable = new List<SomeCustomClass>()
    {
        new SomeCustomClass(),
        new SomeCustomClass(),
    };

    [TableList(ShowPaging = true)] //显示分页
    public List<SomeCustomClass> TableWithPaging = new List<SomeCustomClass>()
    {
        new SomeCustomClass(),
        new SomeCustomClass(),
    };

    [Serializable]
    public class SomeCustomClass
    {
        [TableColumnWidth(57, Resizable = false)]
        [PreviewField(Alignment = ObjectFieldAlignment.Center)]
        public Texture Icon;

        [TextArea]
        public string Description;

        [VerticalGroup("Combined Column"), LabelWidth(22)]
        public string A, B, C;

        [TableColumnWidth(60)]
        [Button, VerticalGroup("Actions")]
        public void Test1() { }

        [TableColumnWidth(60)]
        [Button, VerticalGroup("Actions")]
        public void Test2() { }

        [OnInspectorInit]
        private void CreateData()
        {
            Description = ExampleHelper.GetString();
            Icon = ExampleHelper.GetTexture();
        }
    }
}
