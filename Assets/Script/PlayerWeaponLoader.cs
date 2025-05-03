using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponLoader : MonoBehaviour
{

    public GameObject gunPrefab;
    public GameObject rocketPrefab;
    public GameObject bowPrefab;

    public Transform weaponHolder; // จุดติดอาวุธกับตัวละคร

    private WeaponType currentWeapon;

    void Start()
    {
        currentWeapon = WeaponSelector.selectedWeapon;
        GameObject weaponToSpawn = null;

        // ตรวจดูว่าเลือกอาวุธแบบไหนจาก WeaponSelector
        switch (WeaponSelector.selectedWeapon)
        {
            case WeaponType.Gun:
                weaponToSpawn = gunPrefab;
                break;

            case WeaponType.Rocket:
                weaponToSpawn = rocketPrefab;
                break;

            case WeaponType.Bow:
                weaponToSpawn = bowPrefab;
                break;
        }

        if (weaponToSpawn != null && weaponHolder != null)
        {
            Instantiate(weaponToSpawn, weaponHolder.position, weaponHolder.rotation, weaponHolder);
        }
        else
        {
            Debug.LogWarning("Weapon prefab หรือ weaponHolder ไม่ถูกตั้งค่า");
        }

        currentWeapon = WeaponSelector.selectedWeapon;

    }
}
