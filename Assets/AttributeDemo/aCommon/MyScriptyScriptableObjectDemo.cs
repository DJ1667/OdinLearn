using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[TypeInfoBox("The TypeInfoBox attribute can also be used to display a text at the top of, for example, MonoBehaviours or ScriptableObjects.")]
public class MyScriptyScriptableObjectDemo : ScriptableObject //TypeInfoBox属性也可用于在例如MonoBehaviors或ScriptableObjects的顶部显示文本。
{
    public string MyText = "Hello World";
    [TextArea(10, 15)]
    public string Box;
}
