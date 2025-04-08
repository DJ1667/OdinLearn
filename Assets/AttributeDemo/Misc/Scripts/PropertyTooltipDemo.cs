using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class PropertyTooltipDemo : MonoBehaviour
{
    [PropertyTooltip("This is tooltip on an int property.")]
    public int MyInt;

    [InfoBox("Use $ to refer to a member string.")]
    [PropertyTooltip("$Tooltip")]
    public string Tooltip = "Dynamic tooltip.";

    [Button, PropertyTooltip("Button Tooltip")]
    private void ButtonWithTooltip()
    {
        // ...
    }
}
