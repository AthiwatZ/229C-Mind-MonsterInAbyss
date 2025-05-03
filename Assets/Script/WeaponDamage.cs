using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public enum WeaponType { RPG, Bow, WaterGun }
    public WeaponType weaponType;

    public float GetDamage()
    {
        switch (weaponType)
        {
            case WeaponType.RPG:
                return 9999f;
            case WeaponType.Bow:
                return 555f;
            case WeaponType.WaterGun:
                return 100f;
            default:
                return 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boss"))
        {
            BossHealth boss = other.GetComponent<BossHealth>();
            if (boss != null)
            {
                boss.TakeDamage(GetDamage());
                Debug.Log($"{weaponType} hit the Boss!");
            }

            // ถ้าต้องการให้กระสุนหาย:
            Destroy(gameObject);
        }
    }
}
