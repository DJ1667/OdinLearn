using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

public class HideMonoScriptDemo : MonoBehaviour
{
    [InfoBox("Click the pencil icon to open new inspector for these fields.")]
    public HideMonoScriptDemoScriptableObject Hidden;
    // The script will also be hidden for the ShowMonoScript object if MonoScripts are hidden globally.
    public ShowMonoScriptDemoScriptableObject Shown;
}
