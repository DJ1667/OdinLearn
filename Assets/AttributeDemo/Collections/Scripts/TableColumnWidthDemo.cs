using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

public class TableColumnWidthDemo : MonoBehaviour
{
    [TableList]
    public List<MyItem> List = new List<MyItem>()
    {
        new MyItem(),
        new MyItem(),
        new MyItem(),
    };

    [Serializable]
    public class MyItem
    {
        [PreviewField(Height = 20)]
        [TableColumnWidth(30, Resizable = false)]
        public Texture2D Icon;

        [TableColumnWidth(60)]
        public int ID;

        public string Name;

        [OnInspectorInit]
        private void CreateData()
        {
            Icon = ExampleHelper.GetTexture();
        }
    }
}
