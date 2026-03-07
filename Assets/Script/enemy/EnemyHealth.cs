using UnityEngine;

public class EnemyHealth : Health
{
   public static int countEnemyLive = 0;


   void Awake()
   {
      countEnemyLive++;
   }
   protected override void Die()
   {
      base.Die();
      countEnemyLive--;
      Debug.Log("Enemy died");
   } // Start is called once before the first execution of Update after the MonoBehaviour is created
}
