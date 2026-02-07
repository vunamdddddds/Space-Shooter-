
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject bulletPrelab;

    public float shootingInterval;
    private float lastBulletTime;
    public Transform shootingPoint;

    void Start()
    {

    }

    // Update is called once per frame



    void Update()
    {
        UpdateShoot();

    }

    void UpdateShoot()
    {

        if (Time.time - lastBulletTime >= shootingInterval)
        {
            Shoot();
            lastBulletTime = Time.time;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrelab, shootingPoint.position, transform.rotation);
    }

}