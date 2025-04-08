using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

public class PreviewFieldDemo : MonoBehaviour
{
    [PreviewField]
    public Object RegularPreviewField;

    [VerticalGroup("row1/left")]
    public string A, B, C;

    [HideLabel]
    [PreviewField(50, ObjectFieldAlignment.Right)]
    [HorizontalGroup("row1", 50), VerticalGroup("row1/right")]
    public Object D;

    [HideLabel]
    [PreviewField(50, ObjectFieldAlignment.Left)]  //手制动设置显示方式，设置为左对齐
    [HorizontalGroup("row2", 50), VerticalGroup("row2/left")]
    public Object E;

    [VerticalGroup("row2/right"), LabelWidth(-54)]
    public string F, G, H;

    [PreviewField("preview", FilterMode.Bilinear)]
    public Object I; //还可以直接使这个属性显示别人的内容,但是无法修改他 （骚操作）

    [PreviewField]
    public Texture preview;

    [OnInspectorInit]
    private void CreateData()
    {
        // RegularPreviewField = ExampleHelper.GetTexture();
        // D = ExampleHelper.GetTexture();
        // E = ExampleHelper.GetTexture();
        // I = ExampleHelper.GetMesh();
        // preview = ExampleHelper.GetTexture();
    }

    [InfoBox(
        "These object fields can also be selectively enabled and customized globally " +
        "from the Odin preferences window.\n\n" +
        " - Hold Ctrl + Click = Delete Instance\n" +
        " - Drag and drop = Move / Swap.\n" +
        " - Ctrl + Drag = Replace.\n" +
        " - Ctrl + drag and drop = Move and override.")]
    [PropertyOrder(-1)] //设置在其他属性之前显示
    [Button(ButtonSizes.Large)]
    private void ConfigureGlobalPreviewFieldSettings()
    {
        Sirenix.OdinInspector.Editor.GeneralDrawerConfig.Instance.OpenInEditor(); //可以在Odin偏好设置窗口设置显示方式
    }
}
