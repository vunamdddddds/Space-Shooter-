using UnityEngine;
using UnityEngine.SceneManagement;

public class gameUIScript : MonoBehaviour
{
     void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}