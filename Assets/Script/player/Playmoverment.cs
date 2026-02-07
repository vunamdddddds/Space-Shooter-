using UnityEngine;

public class Playmoverment : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        var worldPoint =
Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;
    }
}
