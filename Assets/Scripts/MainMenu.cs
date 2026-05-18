using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public PlayerStats PlayerStatsReference => PlayerStats.instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    public void PlayLevel()
    {
        
        SceneManager.LoadSceneAsync(1);


    }
    public void QuitGame()
    {
        Application.Quit();

    }
    public void PlayerDeath()
    {
        
        SceneManager.LoadSceneAsync(0);
    }
}
