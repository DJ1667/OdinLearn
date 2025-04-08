using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class TitleDemo : MonoBehaviour
{
    [Title("Titles and Headers")]
    public string MyTitle = "My Dynamic Title";
    public string MySubtitle = "My Dynamic Subtitle";

    [Title("Static title")]
    public int C;
    public int D;

    [Title("Static title", "Static subtitle")] //标题和副标题
    public int E;
    public int F;

    [Title("$MyTitle", "$MySubtitle")] //动态标题和副标题
    public int G;
    public int H;

    [Title("Non bold title", "$MySubtitle", bold: false)] //非粗体标题
    public int I;
    public int J;

    [Title("Non bold title", "With no line seperator", horizontalLine: false, bold: false)] //没有分隔线
    public int K;
    public int L;

    [Title("$MyTitle", "$MySubtitle", TitleAlignments.Right)] //标题右对齐
    public int M;
    public int N;

    [Title("$MyTitle", "$MySubtitle", TitleAlignments.Centered)] //标题居中对齐
    public int O;
    public int P;

    [Title("$Combined", titleAlignment: TitleAlignments.Centered)]
    public int Q;
    public int R;

    [Title("@DateTime.Now.ToString(\"dd:MM:yyyy\")", "@DateTime.Now.ToString(\"HH:mm:ss\")")] //表达式
    public int Expression;

    [ShowInInspector]
    [Title("Title on a Property")] //标题在属性上
    public int S { get; set; }

    [Title("Title on a Method")] //标题在方法上
    [Button]
    public void DoNothing()
    { }

    public string Combined { get { return this.MyTitle + " - " + this.MySubtitle; } }
}
