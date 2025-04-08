using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class DisabledInInlineEditorScriptableObjectDemo : ScriptableObject
{
    public string AlwaysEnabled;

    [DisableInInlineEditors]
    public string DisabledInInlineEditor;
}
