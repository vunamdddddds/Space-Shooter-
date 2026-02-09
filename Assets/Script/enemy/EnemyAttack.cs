using UnityEngine;

class EnemyAttack : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public int damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHeart = collision.GetComponent<PlayerHeart>();

        if (playerHeart != null)
        {
            playerHeart.TakeDamage(damage,"player");
            enemyHealth.TakeDamage(1000,"enemy");

        }
    }


}