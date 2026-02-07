using UnityEngine;

public class bulletKT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float Plyspeed;

    public float lifeTime;
    private float curTimer = 0f;
    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * Plyspeed;
        transform.position = newPosition;
        LifeTime();
       
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
 Destroy(gameObject);

    }

    void LifeTime()
    {
        curTimer += Time.deltaTime;
        if (curTimer >= lifeTime)
        {
            Destroy(gameObject);
            curTimer = 0f;
        }


    }
  




}
