
using UnityEngine;

public class PlayerMoverment : MonoBehaviour
{

    void Update()
    {
        var MousePosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z=0;
        transform.position=MousePosition;
    }


}