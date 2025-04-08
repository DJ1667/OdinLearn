using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class PropertySpaceDemo : MonoBehaviour
{
    // PropertySpace and Space attributes are virtually identical.
    [Space]
    [BoxGroup("Space", ShowLabel = false)]
    public int Space;

    // You can also control spacing both before and after the PropertySpace attribute.
    [PropertySpace(SpaceBefore = 30, SpaceAfter = 60)]
    [BoxGroup("BeforeAndAfter", ShowLabel = false)]
    public int BeforeAndAfter; //可以控制前面和后面的间距

    // The PropertySpace attribute can, as the name suggests, also be applied to properties.
    [PropertySpace]
    [ShowInInspector, BoxGroup("Property", ShowLabel = false)]
    public string Property { get; set; } //可以应用到属性上
}
