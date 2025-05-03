using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponLoader : MonoBehaviour
{
    public GameObject bowPrefab;
    public GameObject gunPrefab;
    public GameObject rocketPrefab;
    public Transform weaponHolder; // จุดติดอาวุธ (เช่นมือ)

    void Start()
    {
        GameObject weaponToSpawn = null;

        switch (WeaponSelector.selectedWeaponName)
        {
            case "Bow":
                weaponToSpawn = bowPrefab;
                break;
            case "Sword":
                weaponToSpawn = gunPrefab;
                break;
            case "Rocket":
                weaponToSpawn = rocketPrefab;
                break;
        }

        if (weaponToSpawn != null && weaponHolder != null)
        {
            Instantiate(weaponToSpawn, weaponHolder.position, weaponHolder.rotation, weaponHolder);
        }
        else
        {
            Debug.LogWarning("ไม่มีอาวุธที่เลือกหรือยังไม่ได้ตั้ง WeaponHolder");
        }
    }
}
