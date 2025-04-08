using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using Sirenix.Utilities;
using UnityEngine;

public class TableMatrixDemo : SerializedMonoBehaviour
{
    [TableMatrix(HorizontalTitle = "Square Celled Matrix", SquareCells = true)]
    public Texture2D[,] SquareCelledMatrix; //单个Cell设置为正方形

    [TableMatrix(SquareCells = false)]
    public Mesh[,] PrefabMatrix;

    [OnInspectorInit]
    private void CreateData()
    {
        SquareCelledMatrix = new Texture2D[8, 4]
        {
        { ExampleHelper.GetTexture(), null, null, null },
        { null, ExampleHelper.GetTexture(), null, null },
        { null, null, ExampleHelper.GetTexture(), null },
        { null, null, null, ExampleHelper.GetTexture() },
        { ExampleHelper.GetTexture(), null, null, null },
        { null, ExampleHelper.GetTexture(), null, null },
        { null, null, ExampleHelper.GetTexture(), null },
        { null, null, null, ExampleHelper.GetTexture() },
        };

        PrefabMatrix = new Mesh[8, 4]
        {
        { ExampleHelper.GetMesh(), null, null, null },
        { null, ExampleHelper.GetMesh(), null, null },
        { null, null, ExampleHelper.GetMesh(), null },
        { null, null, null, ExampleHelper.GetMesh() },
        { null, null, null, ExampleHelper.GetMesh() },
        { null, null, ExampleHelper.GetMesh(), null },
        { null, ExampleHelper.GetMesh(), null, null },
        { ExampleHelper.GetMesh(), null, null, null },
        };

        this.CustomCellDrawing = new bool[15, 15];
        this.CustomCellDrawing[6, 5] = true;
        this.CustomCellDrawing[6, 6] = true;
        this.CustomCellDrawing[6, 7] = true;
        this.CustomCellDrawing[8, 5] = true;
        this.CustomCellDrawing[8, 6] = true;
        this.CustomCellDrawing[8, 7] = true;
        this.CustomCellDrawing[5, 9] = true;
        this.CustomCellDrawing[5, 10] = true;
        this.CustomCellDrawing[9, 9] = true;
        this.CustomCellDrawing[9, 10] = true;
        this.CustomCellDrawing[6, 11] = true;
        this.CustomCellDrawing[7, 11] = true;
        this.CustomCellDrawing[8, 11] = true;
    }

    [TableMatrix(HorizontalTitle = "Read Only Matrix", IsReadOnly = true)]
    // [ReadOnly]
    public int[,] ReadOnlyMatrix = new int[5, 5]; //插入、删除和拖动列和行将不可用。但Cell本身仍将是可修改的,如果想要禁用所有操作，可以使用ReadOnly属性

    [TableMatrix(HorizontalTitle = "X axis", VerticalTitle = "Y axis")]
    public InfoMessageType[,] LabledMatrix = new InfoMessageType[6, 6]; //设置X轴和Y轴的标题

    [TableMatrix(HorizontalTitle = "Custom Cell Drawing", DrawElementMethod = "DrawColoredEnumElement", ResizableColumns = false, RowHeight = 16)]
    public bool[,] CustomCellDrawing; //自定义Cell的绘制, ResizableColumns为false时，无法调整列宽

    [ShowInInspector, DoNotDrawAsReference]
    [TableMatrix(HorizontalTitle = "Transposed Custom Cell Drawing", DrawElementMethod = "DrawColoredEnumElement", ResizableColumns = false, RowHeight = 16, Transpose = true)]
    public bool[,] Transposed { get { return CustomCellDrawing; } set { CustomCellDrawing = value; } } //转置矩阵

    private static bool DrawColoredEnumElement(Rect rect, bool value)
    {
        if (Event.current.type == EventType.MouseDown && rect.Contains(Event.current.mousePosition))
        {
            value = !value;
            GUI.changed = true;
            Event.current.Use();
        }

        UnityEditor.EditorGUI.DrawRect(rect.Padding(1), value ? new Color(0.1f, 0.8f, 0.2f) : new Color(0, 0, 0, 0.5f));

        return value;
    }
}
