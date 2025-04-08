using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class DetailedInfoBox : MonoBehaviour
{
    [DetailedInfoBox("Click the DetailedInfoBox...",
        "... to reveal more information!\n" +
        "This allows you to reduce unnecessary clutter in your editors, and still have all the relavant information available when required.")]
    public int Field;
}
