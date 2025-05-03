using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Gun,
    Rocket,
    Bow
}
public static class WeaponSelector
{
    public static WeaponType selectedWeapon = WeaponType.Gun;
}
