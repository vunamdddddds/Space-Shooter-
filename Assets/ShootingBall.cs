using UnityEngine;

public class ShootingBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ballPrefab;

    public Vector3 spawnPosition;

    private float lastBulletTime;

    public float shootingInterval;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFiring();
    }


void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBall();
            lastBulletTime = Time.time;

        }
    }

    void ShootBall()
    {
        Instantiate(ballPrefab, transform.position + spawnPosition, transform.rotation);
    }
}
