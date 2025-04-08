using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

public class TypeFilterDemo : SerializedMonoBehaviour
{
    [TypeFilter("GetFilteredTypeList")]
    public BaseClass A, B;

    public BaseClass C;

    [TypeFilter("GetFilteredTypeList")]
    public BaseClass[] Array = new BaseClass[3];

    public IEnumerable<Type> GetFilteredTypeList()
    {
        var q = typeof(BaseClass).Assembly.GetTypes()
            .Where(x => !x.IsAbstract)                                          // 排除抽象类 排除BaseClass
            .Where(x => !x.IsGenericTypeDefinition)                             // 排除未实例化的泛型类定义 排除C1<>
            .Where(x => typeof(BaseClass).IsAssignableFrom(x));                 // 仅保留继承自BaseClass的类 排除不继承BaseClass的类

        // 添加各种C1<T>泛型类型的变体
        q = q.AppendWith(typeof(C1<>).MakeGenericType(typeof(GameObject)));
        q = q.AppendWith(typeof(C1<>).MakeGenericType(typeof(AnimationCurve)));
        q = q.AppendWith(typeof(C1<>).MakeGenericType(typeof(List<float>)));

        return q;
    }

    public abstract class BaseClass
    {
        public int BaseField;
    }

    public class A1 : BaseClass { public int _A1; }
    public class A2 : A1 { public int _A2; }
    public class A3 : A2 { public int _A3; }
    public class B1 : BaseClass { public int _B1; }
    public class B2 : B1 { public int _B2; }
    public class B3 : B2 { public int _B3; }
    public class C1<T> : BaseClass { public T C; }
}
