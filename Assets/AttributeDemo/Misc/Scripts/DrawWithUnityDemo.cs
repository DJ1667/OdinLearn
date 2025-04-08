using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class DrawWithUnityDemo : MonoBehaviour
{
    [InfoBox("如果您在使用 Odin 的属性时遇到问题，DrawWithUnity 很可能会派上用场；它会让 Odin 像 Unity 正常绘制那样来绘制这个值。")]
    public GameObject ObjectDrawnWithOdin;

    [DrawWithUnity]
    public GameObject ObjectDrawnWithUnity;
}
