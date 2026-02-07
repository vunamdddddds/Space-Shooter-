using UnityEngine;

public class EnemyHealth : Health
{
   protected override void Die()
   {
      base.Die();
      Debug.Log("Enemy died");
   } // Start is called once before the first execution of Update after the MonoBehaviour is created
}
