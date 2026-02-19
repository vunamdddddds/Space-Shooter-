using UnityEngine;

public class PlayerHeart : Health
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject gameOverUI;
    protected override void Die()
    {
        Debug.Log("Player died");
        base.Die();
        gameOverUISetActive();
    }

    private void gameOverUISetActive()
    {
        gameOverUI.SetActive(true);
    }

}

