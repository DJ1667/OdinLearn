using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class UnitDemo : MonoBehaviour
{
    // 千克单位。右键点击可以更改显示。
    // 尝试输入 '6 lb'。
    [Unit(Units.Kilogram)]
    public float Weight;

    // 米每秒单位,在检视面板中显示为千米每小时。
    // 尝试输入 '15 mph'。
    [Unit(Units.MetersPerSecond, Units.KilometersPerHour)]
    public float Speed;

    // 米单位,在检视面板中显示为厘米。
    // 尝试输入 '150 cm'。
    [Unit(Units.Meter, Units.Centimeter)]
    public float Distance;

    // 速度值,在检视面板中显示为英里每小时。非常适合在检视面板中调试值。
    [ShowInInspector, Unit(Units.MetersPerSecond, Units.MilesPerHour, DisplayAsString = true, ForceDisplayUnit = true)]
    public float SpeedMilesPerHour => Speed;

    // 添加自定义单位。(禁用以不将自定义单位添加到项目中)
    //[InitializeOnLoadMethod]
    //public static void AddCustomUnit()
    //{
    //    UnitNumberUtility.AddCustomUnit(
    //      name: "Odin",
    //      symbols: new string[] { "odin" },
    //      unitCategory: UnitCategory.Distance,
    //      multiplier: 1m / 42m);
    //}

    // 通过名称引用自定义单位。
    //[Unit(Units.Meter, "Odin")]
    //public float Odins;
}
