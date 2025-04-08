using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ButtonGroupDemo : MonoBehaviour
{
    public IconButtonGroupExamples iconButtonGroupExamples;

    [ButtonGroup]
    private void A()
    {
    }

    [ButtonGroup]
    private void B()
    {
    }

    [ButtonGroup]
    private void C()
    {
    }

    [ButtonGroup]
    private void D()
    {
    }

    [Button(ButtonSizes.Large)]
    [ButtonGroup("My Button Group")]
    private void E()
    {
    }

    [GUIColor(0, 1, 0)]
    [ButtonGroup("My Button Group")]
    private void F()
    {
    }

    [Space(30)]

    [BoxGroup("Titles", ShowLabel = false)]
    [TitleGroup("Titles/First Title")]
    [PropertyOrder(5)]
    public int AA;

    [BoxGroup("Titles/Boxed")]
    [TitleGroup("Titles/Boxed/Second Title")]
    [PropertyOrder(5)]
    public int BB;

    [TitleGroup("Titles/Boxed/Second Title")]
    [PropertyOrder(5)]
    public int CC;

    [TitleGroup("Titles/Horizontal Buttons")]
    [ButtonGroup("Titles/Horizontal Buttons/Buttons")]
    [PropertyOrder(5)]
    public void FirstButton() { }

    [ButtonGroup("Titles/Horizontal Buttons/Buttons")]
    [PropertyOrder(5)]
    public void SecondButton() { }

    [Serializable, HideLabel]
    public struct IconButtonGroupExamples
    {
        [ButtonGroup(ButtonHeight = 25), Button(SdfIconType.ArrowsMove, "")]
        void ArrowsMove() { }

        [ButtonGroup, Button(SdfIconType.Crop, "")]
        void Crop() { }

        [ButtonGroup, Button(SdfIconType.TextLeft, "")]
        void TextLeft() { }

        [ButtonGroup, Button(SdfIconType.TextRight, "")]
        void TextRight() { }

        [ButtonGroup, Button(SdfIconType.TextParagraph, "")]
        void TextParagraph() { }

        [ButtonGroup, Button(SdfIconType.Textarea, "")]
        void Textarea() { }
    }
}
