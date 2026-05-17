using UnityEngine;
using UnityEngine.UI;
public class PlayerHealthBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider slider;
    public PlayerStats PlayerStatsReference => PlayerStats.instance;
    void Start()
    {
        slider.maxValue = PlayerStatsReference.PlayerMaxHealth;
        slider.value = PlayerStatsReference.PlayerMaxHealth;

        print(PlayerStatsReference);
    }
    void Awake()
    {
        
        slider = GetComponentInChildren<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHealthOnChange()
    {
        slider.value = PlayerStatsReference.PlayerHealth;
        print(slider);
        print("fuck");
        
    }
    public void SetHealthOnLevelStart()
    {
        slider.maxValue = PlayerStatsReference.PlayerMaxHealth;
        slider.value = PlayerStatsReference.PlayerMaxHealth;

    }
    public void SetHealthOnLevelUp()
    {
        slider.maxValue = PlayerStatsReference.PlayerMaxHealth;
        slider.value = PlayerStatsReference.PlayerHealth;

    }

}


