using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using UnityEngine;

public class OnInspectorInitDemo : MonoBehaviour
{
    // Display current time for reference.
    [ShowInInspector, DisplayAsString, PropertyOrder(-1)]
    public string CurrentTime
    {
        get
        {
            GUIHelper.RequestRepaint();
            return DateTime.Now.ToString();
        }
    }

    // OnInspectorInit 在属性第一次在检视面板中绘制之前执行。
    // 当示例重新选择时也会再次执行。
    [OnInspectorInit("@TimeWhenExampleWasOpened = DateTime.Now.ToString()")]
    public string TimeWhenExampleWasOpened;

    // OnInspectorInit 在属性实际在检视面板中"解析"之前不会执行。
    // 请记住，Odin的属性系统是惰性求值的，因此在实际请求属性之前，
    // 该属性实际上并不存在且未初始化。
    // 
    // 因此，这个OnInspectorInit特性只有在折叠面板展开时才会执行。
    [FoldoutGroup("Delayed Initialization", Expanded = false, HideWhenChildrenAreInvisible = false)]
    [OnInspectorInit("@TimeFoldoutWasOpened = DateTime.Now.ToString()")]
    public string TimeFoldoutWasOpened;
}
