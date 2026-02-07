using System.Diagnostics;
using UnityEngine;

public class bulletEnemyMov : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float plySpeed;
    public float lifeTime;
    private float curTimer = 0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y -= Time.deltaTime * plySpeed;
        transform.position = newPosition;
        LifeTime();

    }

    void LifeTime()
    {

        if (curTimer >= lifeTime)
        {
            Destroy(gameObject);
            curTimer = 0f;
        }
        curTimer += Time.deltaTime;
    }

}
