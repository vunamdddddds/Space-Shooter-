using UnityEngine;
using UnityEngine.PlayerLoop;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    private Vector2 vector2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            shooting();
        }
        
    }
    void shooting()
    {
       transform.Translate(Vector2.up * Time.deltaTime * 10);
    }
}
