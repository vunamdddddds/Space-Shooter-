using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;

    public float lifeTime;
    private float curTimer = 0f;
    public int damage;


    void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            Debug.Log("Enemy hit");
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
        KillBullet(); // bổ sung thêm thời gian sống của viên đạn 
    }

    // hàm viết bổ sung thêm thời gian sống của viên đạn 
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


