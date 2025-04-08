using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class InlineButtonDemo : MonoBehaviour
{
    // Inline Buttons:
    [InlineButton("A")]
    public int InlineButton;

    [InlineButton("A")]
    [InlineButton("B", "Custom Button Name")]
    public int ChainedButtons;

    [InlineButton("C", SdfIconType.Dice6Fill, "Random")]
    public int IconButton;

    private void A()
    {
        Debug.Log("A");
    }

    private void B()
    {
        Debug.Log("B");
    }

    private void C()
    {
        Debug.Log("C");
    }
}
