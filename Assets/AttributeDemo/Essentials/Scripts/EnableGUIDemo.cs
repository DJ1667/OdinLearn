using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class EnableGUIDemo : MonoBehaviour
{
    [ShowInInspector]
    public int GUIDisabledProperty { get { return 10; } }

    [ShowInInspector, EnableGUI]
    public int GUIEnabledProperty { get { return 10; } }

    [ShowInInspector]
    public int GUIDisabledProperty2 { get; set; }

    [ShowInInspector, EnableGUI]
    public int GUIEnabledProperty2 { get; set; }
}
