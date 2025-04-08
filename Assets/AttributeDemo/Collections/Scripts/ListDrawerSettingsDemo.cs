using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using UnityEngine;

public class ListDrawerSettingsDemo : MonoBehaviour
{
    [PropertyOrder(int.MinValue), OnInspectorGUI]
    private void DrawIntroInfoBox()
    {
        SirenixEditorGUI.InfoMessageBox("开箱即用，Odin 显著提升了 Inspector 中列表和数组的绘制功能 - 全面升级，无需任何额外配置。");
    }

    [Title("List Basics")]
    [InfoBox("列表元素现在可以拖动以重新排序，并可以单独删除，列表具有分页功能（尝试添加大量元素！）。你仍然可以从项目视图中拖动多个资产一次进入列表 - 只需将它们拖入列表本身并插入你想要添加的位置。")]
    public List<float> FloatList;

    [InfoBox("将 [Range] 属性应用于此列表。")]
    [Range(0, 1)]
    public float[] FloatRangeArray;

    [InfoBox("列表可以以不同方式设置为只读。")]
    [ListDrawerSettings(IsReadOnly = true)] //从列表中删除所有编辑功能 例如添加、拖动和删除
    public int[] ReadOnlyArray1 = new int[] { 1, 2, 3 };

    [ReadOnly]
    public int[] ReadOnlyArray2 = new int[] { 1, 2, 3 };

    public SomeOtherStruct[] SomeStructList;

    [Title("Advanced List Customization")]
    [InfoBox("使用 [ListDrawerSettings]，列表可以以多种方式自定义。")]
    [ListDrawerSettings(NumberOfItemsPerPage = 5)]
    public int[] FiveItemsPerPage;

    [ListDrawerSettings(ShowIndexLabels = true, ListElementLabelName = "SomeString")] //显示索引标签 并使用子元素的字段 SomeString 作为元素标签
    public SomeStruct[] IndexLabels;

    [ListDrawerSettings(DraggableItems = false, ShowFoldout = false, ShowIndexLabels = true, ShowPaging = false, ShowItemCount = false,
                        HideRemoveButton = true)]
    public int[] MoreListSettings = new int[] { 1, 2, 3 }; //隐藏删除按钮 隐藏折叠按钮 隐藏索引标签 隐藏分页 隐藏元素计数

    [ListDrawerSettings(OnBeginListElementGUI = "BeginDrawListElement", OnEndListElementGUI = "EndDrawListElement")]
    public SomeStruct[] InjectListElementGUI; //在开始和结束列表元素时调用方法

    [ListDrawerSettings(OnTitleBarGUI = "DrawRefreshButton")]
    public List<int> CustomButtons; //自定义标题栏

    [ListDrawerSettings(CustomAddFunction = "CustomAddFunction")]
    public List<int> CustomAddBehaviour; //自定义添加行为

    [Serializable]
    public struct SomeStruct
    {
        public string SomeString;
        public int One;
        public int Two;
        public int Three;
    }

    [Serializable]
    public struct SomeOtherStruct
    {
        [HorizontalGroup("Split", 55), PropertyOrder(-1)]
        [PreviewField(50, Sirenix.OdinInspector.ObjectFieldAlignment.Left), HideLabel]
        public UnityEngine.MonoBehaviour SomeObject;

        [FoldoutGroup("Split/$Name", false)]
        public int A, B, C;

        [FoldoutGroup("Split/$Name", false)]
        public int Two;

        [FoldoutGroup("Split/$Name", false)]
        public int Three;

        private string Name { get { return this.SomeObject ? this.SomeObject.name : "Null"; } }
    }

    private void BeginDrawListElement(int index)
    {
        SirenixEditorGUI.BeginBox(this.InjectListElementGUI[index].SomeString);
        SirenixEditorGUI.Title("这是一个标题", "这是一个副标题", TextAlignment.Center, false, false);
    }

    private void EndDrawListElement(int index)
    {
        SirenixEditorGUI.EndBox();
    }

    private void DrawRefreshButton()
    {
        if (SirenixEditorGUI.ToolbarButton(EditorIcons.Refresh))
        {
            Debug.Log(this.CustomButtons.Count.ToString());
        }
    }

    private int CustomAddFunction()
    {
        return this.CustomAddBehaviour.Count;
    }
}
