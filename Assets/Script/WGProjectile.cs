using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WGProjectile : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject target;
    public Rigidbody2D gunBulletPrefab;
    public Rigidbody2D rocketBulletPrefab;
    public Rigidbody2D arrowBulletPrefab;

    public WeaponType currentWeapon => WeaponSelector.selectedWeapon;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // แปลงตำแหน่งเมาส์ในจอ เป็นตำแหน่งในโลก 2D
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 5f, Color.magenta, 5f);

            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                target.transform.position = new Vector2(hit.point.x, hit.point.y);

                Vector2 projectileVelocity = CalculateProjectileVelocity(shootPoint.position, hit.point, 1f);

                Rigidbody2D bulletToFire = null;

                switch (currentWeapon)
                {
                    case WeaponType.Gun:
                        bulletToFire = Instantiate(gunBulletPrefab, shootPoint.position, Quaternion.identity);
                        bulletToFire.velocity = projectileVelocity;
                        break;

                    case WeaponType.Rocket:
                        bulletToFire = Instantiate(rocketBulletPrefab, shootPoint.position, Quaternion.identity);
                        bulletToFire.velocity = projectileVelocity;
                        bulletToFire.GetComponent<SpriteRenderer>().color = Color.red;
                        break;

                    case WeaponType.Bow:
                        bulletToFire = Instantiate(arrowBulletPrefab, shootPoint.position, Quaternion.identity);
                        bulletToFire.velocity = projectileVelocity;
                        bulletToFire.gravityScale = 2f; // ลูกศรตกเร็วขึ้น
                        break;
                }

            }//hit.collider

        }//GetMouseButtonDown
    }

    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin;

        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        return new Vector2(velocityX, velocityY);

    }// CalculateProjectileVelocity

}
