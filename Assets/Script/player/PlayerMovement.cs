using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 SpawnPosition;
    // Update is called once per frame
    void Start()
    {
        transform.position = SpawnPosition;
    }
    void Update()
    {
        var worldPoint =
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;
    }
}