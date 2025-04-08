using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class InfoBoxDemo : MonoBehaviour
{
    [Title("InfoBox message types")]
    [InfoBox("Default info box.")]
    public int A;

    [InfoBox("Warning info box.", InfoMessageType.Warning)]
    public int B;

    [InfoBox("Error info box.", InfoMessageType.Error)]
    public int C;

    [InfoBox("Info box without an icon.", InfoMessageType.None)] // 没有图标的信息框
    public int D;

    [Title("Conditional info boxes")] // 条件信息框
    public bool ToggleInfoBoxes;

    [InfoBox("This info box is only shown while in editor mode.", InfoMessageType.Error, "IsInEditMode")]
    public float G;

    [InfoBox("This info box is hideable by a static field.", "ToggleInfoBoxes")]
    public float E;

    [InfoBox("This info box is hideable by a static field.", "ToggleInfoBoxes")]
    public float F;

    [Title("Info box member reference and attribute expressions")] // 信息框成员引用和属性表达式
    [InfoBox("$InfoBoxMessage")]
    [InfoBox("@\"Time: \" + DateTime.Now.ToString(\"HH:mm:ss\")")] // 动态信息框消息
    public string InfoBoxMessage = "My dynamic info box message";

    private static bool IsInEditMode()
    {
        return !Application.isPlaying;
    }
}
