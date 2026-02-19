using UnityEngine;
using UnityEngine.UIElements;

public class HeartEnemy : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health;
    private int curHealth;


    void Start()
    {
        curHealth = health;

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (curHealth <= 0)
        {
            Die();
            Debug.Log("Enemy died");
        }
        else
        {
            curHealth -= 1;
            Debug.Log("curHealth:" + curHealth);
        }

    }

    void Die()
    {
        Destroy(gameObject);

    }
}
