using UnityEngine;

public class BulletBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float flySpeed ;

    public float lifeTime ;
    private float curTimer = 0f;
        public int damage;


       void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerHeart>();
        if (player != null)
        {
            Debug.Log("Player hit");
            player.TakeDamage(damage,"player");
            Destroy(gameObject);
        }
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
        curTimer += Time.deltaTime;
        if (curTimer >= lifeTime)
        {
            Destroy(gameObject);
            curTimer = 0f;
        }

    }
}
