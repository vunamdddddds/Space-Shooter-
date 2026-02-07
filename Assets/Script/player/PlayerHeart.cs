using UnityEngine;

public class PlayerHeart : Health
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Die()
    {        Debug.Log("Player died");
        base.Die();
    }


}
