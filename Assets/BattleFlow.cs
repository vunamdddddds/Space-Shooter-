using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public AudioSource audioSource;
    public PlayerHeart playerHealth;
    public GameObject gameOverUI;
    public GameObject winUI;

    void Start()
    {
        gameOverUI.SetActive(false);
        playerHealth.onDead += OnPlayerDead; // Đăng ký sự kiện khi người chơi chết
    }

    void Update()
    {

        if (EnemyHealth.countEnemyLive <= 0)
        {
            OnPlayerWin();
        }
    }
    private void OnPlayerWin()
    {
        Debug.Log("Player wins! All enemies are defeated.");
        winUI.SetActive(true); // Hiển thị giao diện chiến thắng

    }

    private void OnPlayerDead()
    {
        Debug.Log("Player is dead. Game Over!");
        audioSource.Stop(); // Dừng âm thanh khi người chơi chết
        gameOverUI.SetActive(true); // Hiển thị giao diện Game Over
    }
}
