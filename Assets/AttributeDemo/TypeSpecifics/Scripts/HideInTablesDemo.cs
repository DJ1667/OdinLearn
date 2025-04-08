using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class HideInTablesDemo : MonoBehaviour
{
    public MyItem Item = new MyItem();

    [TableList]
    public List<MyItem> Table = new List<MyItem>()
    {
        new MyItem(),
        new MyItem(),
        new MyItem(),
    };

    [Serializable]
    public class MyItem
    {
        public string A;

        public int B;

        [HideInTables]
        public int Hidden; // 在Table中隐藏这个属性
    }
}
