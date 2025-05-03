using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponSelectMenu : MonoBehaviour
{
    public void SelectWeapon(string weaponName)
    {
        switch (weaponName)
        {
            case "Gun":
                WeaponSelector.selectedWeapon = WeaponType.Gun;
                break;
            case "Rocket":
                WeaponSelector.selectedWeapon = WeaponType.Rocket;
                break;
            case "Bow":
                WeaponSelector.selectedWeapon = WeaponType.Bow;
                break;
            default:
                WeaponSelector.selectedWeapon = WeaponType.Gun;
                break;
        }

        SceneManager.LoadScene("VsBoss"); // ใส่ชื่อซีนที่ใช้จริง
    }
}
