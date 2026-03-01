using UnityEngine;

public class BulletPlayer : BulletCha
{
    
    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
        KillBullet(); // bổ sung thêm thời gian sống của viên đạn 
    }

    
 
}


