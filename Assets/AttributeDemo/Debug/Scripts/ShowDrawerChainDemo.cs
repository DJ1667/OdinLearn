using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ShowDrawerChainDemo : MonoBehaviour
{
    [HorizontalGroup(Order = 1)]
    [ShowInInspector, ToggleLeft]
    public bool ToggleHideIf { get { Sirenix.Utilities.Editor.GUIHelper.RequestRepaint(); return UnityEditor.EditorApplication.timeSinceStartup % 3 < 1.5f; } }

    [HorizontalGroup]
    [ShowInInspector, HideLabel, ProgressBar(0, 1.5f)]
    private double Animate { get { return Math.Abs(UnityEditor.EditorApplication.timeSinceStartup % 3 - 1.5f); } }

    [InfoBox(
        "Any drawer not used will be greyed out so that you can more easily debug the drawer chain. You can see this by toggling the above toggle field.\n\n" +
        "If you have any custom drawers they will show up with green names in the drawer chain.")]
    [ShowDrawerChain]
    [HideIf("ToggleHideIf")]
    [PropertyOrder(2)]
    public GameObject SomeObject;

    [Range(0, 10)]
    [ShowDrawerChain]
    public float SomeRange;
}
