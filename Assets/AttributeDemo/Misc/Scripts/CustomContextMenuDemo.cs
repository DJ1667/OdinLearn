using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class CustomContextMenuDemo : MonoBehaviour
{
    [InfoBox("在这个属性上添加了自定义上下文菜单。右键点击属性可以查看自定义上下文菜单。")]
    [CustomContextMenu("Say Hello/Twice", "SayHello")]
    public int MyProperty;

    private void SayHello()
    {
        Debug.Log("Hello Twice");
    }
}
