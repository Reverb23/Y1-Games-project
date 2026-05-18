using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    private bool NextSceneLoaded = false;
    public void NextScene()
    {
        if (NextSceneLoaded == false)
        {
            SceneManager.LoadScene(0);

            NextSceneLoaded = true;
        }
        
    }
}