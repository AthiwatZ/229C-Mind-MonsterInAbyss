using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponSelectMenu : MonoBehaviour
{
    public void SelectWeapon(string weaponName)
    {
        WeaponSelector.selectedWeaponName = weaponName;
        SceneManager.LoadScene("VsBoss"); // เปลี่ยนชื่อซีนตามของคุณ
    }
}
