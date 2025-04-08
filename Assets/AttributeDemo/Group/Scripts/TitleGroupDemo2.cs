using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class TitleGroupDemo2 : MonoBehaviour
{
    [BoxGroup("Titles", ShowLabel = false)]
    [TitleGroup("Titles/First Title")]
    public int A;

    [BoxGroup("Titles/Boxed")]
    [TitleGroup("Titles/Boxed/Second Title")]
    public int B;

    [TitleGroup("Titles/Boxed/Second Title")]
    public int C;

    [TitleGroup("Titles/Horizontal Buttons")]
    [ButtonGroup("Titles/Horizontal Buttons/Buttons")]
    public void FirstButton() { }

    [ButtonGroup("Titles/Horizontal Buttons/Buttons")]
    public void SecondButton() { }
}
