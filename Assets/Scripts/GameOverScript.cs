using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using System;
public class GameOverScript : MonoBehaviour
{
    public UpdateKillLabel UpdateKillLabelReference;
    public  Control Deathloader;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool PlayerDead = false;
    public TMP_Text text;

    public void Setup()
    {
        
        gameObject.SetActive(true);
        text.text = "Score: " +  Convert.ToString(UpdateKillLabelReference.TotalKillCount);


    }
    
    public void MainMenuCall()
    {
        Deathloader.NextScene();

        
    }
    public void RetryGameCall()
    {
        Deathloader.RetryGame();

        
    }

}
