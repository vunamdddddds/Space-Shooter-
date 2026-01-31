using UnityEngine;

public class BulletBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float flySpeed ;

    public float lifeTime ;
    private float lifeTimer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y -= Time.deltaTime * flySpeed;
        transform.position = newPosition;
        KillBullet();
    }

    void KillBullet()
    {
        lifeTimer += Time.deltaTime;
        if (lifeTimer >= lifeTime)
        {
            Destroy(gameObject);
            lifeTimer = 0f;
        }

    }
}
