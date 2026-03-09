using UnityEngine;
public class ShootingCha : MonoBehaviour
{
    
    public GameObject ballPrefab;

    public Vector3 spawnPosition;

    private float lastBulletTime;

    public float shootingInterval;

  


    protected void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBall();
            lastBulletTime = Time.time;

        }
    }

   protected void ShootBall()
    {
        Instantiate(ballPrefab, transform.position + spawnPosition, transform.rotation);
    }
    
}