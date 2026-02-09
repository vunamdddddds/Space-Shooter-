using UnityEngine;


public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;

    void Start()
    {
        healthPoint = defaultHealthPoint;
    }



    public void TakeDamage(int damage,string name)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        Debug.Log("Health "+name +":"+ healthPoint);

        if (healthPoint <= 0) {            
            Die();};
    }
    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position,
        transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }
}