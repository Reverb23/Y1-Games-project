using System;
using System.Collections;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateKillLabel : MonoBehaviour
{
    public int TotalKillCount = 0;
    public PlayerStats PlayerStatsReference => PlayerStats.instance;
    public TMP_Text text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        text.text = "Level Up " + Convert.ToString(PlayerStatsReference.KillCount)+"/"+Convert.ToString(PlayerStatsReference.LevelUpKills) + "\n" + "Level " + Convert.ToString(PlayerStatsReference.PlayerLevel)+"\n" + "Score: " + TotalKillCount;        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateKillCount()
    {
        TotalKillCount ++;
        text.text = "Level Up " + Convert.ToString(PlayerStatsReference.KillCount)+"/"+Convert.ToString(PlayerStatsReference.LevelUpKills) + "\n" + "Level " + Convert.ToString(PlayerStatsReference.PlayerLevel)+"\n" + "Score: " + TotalKillCount;        

    }

}
