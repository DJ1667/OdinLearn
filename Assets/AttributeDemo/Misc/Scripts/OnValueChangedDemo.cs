using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class OnValueChangedDemo : MonoBehaviour
{
    [OnValueChanged("ChangeCount")]
    public bool OnStateChange;
    public int count = 0;
    private void ChangeCount()
    {
        count++;
    }
}
