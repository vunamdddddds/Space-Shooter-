using UnityEngine;
using UnityEngine.PlayerLoop;

public class ShootKT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

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
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime >= shootingInterval)
            {
                Shoot();
                lastBulletTime = Time.time;

            }
        }

    }

    void Shoot()
    {

        Instantiate(bulletPrelab, shootingPoint.position, transform.rotation);

    }

}
