using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class DisableContextMenuDemo : MonoBehaviour
{
    [InfoBox("DisableContextMenu 禁用所有由 Odin 提供的右键上下文菜单。它不会禁用 Unity 的上下文菜单。", InfoMessageType.Warning)]
    [DisableContextMenu]
    public int[] NoRightClickList = new int[] { 2, 3, 5 };

    [DisableContextMenu(disableForMember: false, disableCollectionElements: true)]
    public int[] NoRightClickListOnListElements = new int[] { 7, 11 };

    [DisableContextMenu(disableForMember: true, disableCollectionElements: true)]
    public int[] DisableRightClickCompletely = new int[] { 13, 17 };

    [DisableContextMenu]
    public int NoRightClickField = 19;
}
