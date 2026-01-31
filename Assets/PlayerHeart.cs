using UnityEngine;

public class PlayerHeart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject BallPrefab;


    public GameObject explosionEffect;




    void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    void Die()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(explosionEffect, 1f);
        Destroy(gameObject);
        Destroy(BallPrefab);
    }

}
