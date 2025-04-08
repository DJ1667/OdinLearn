using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEngine;

public class OnCollectionChangedDemo : SerializedMonoBehaviour
{
    [InfoBox("修改集合以获取详细说明所做更改的回调。")]
    [OnCollectionChanged("Before", "After")]
    public List<string> list = new List<string>() { "str1", "str2", "str3" };

    [OnCollectionChanged("Before", "After")]
    public HashSet<string> hashset = new HashSet<string>() { "str1", "str2", "str3" };

    [OnCollectionChanged("Before", "After")]
    public Dictionary<string, string> dictionary = new Dictionary<string, string>() { { "key1", "str1" }, { "key2", "str2" }, { "key3", "str3" } };

    public void Before(CollectionChangeInfo info, object value)
    {
        Debug.Log("收到更改前的回调,信息为: " + info + ", 集合实例为: " + value);
    }

    public void After(CollectionChangeInfo info, object value)
    {
        Debug.Log("收到更改后的回调,信息为: " + info + ", 集合实例为: " + value);
    }
}
