using UnityEngine;

public class PlayerShootingv1 : ShootingCha
{
    // Start is called once before the first execution of Update after the MonoBehaviour is createdpublic GameObject bulletPrefabs;


    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            UpdateFiring();
        }
    }

   


}
