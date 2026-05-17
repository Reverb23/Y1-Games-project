using UnityEngine;
using UnityEngine.UI;
public class EnemyHealthBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider slider;
    public EnemyFollowing EnemyFollowingReference;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHealthOnChange()
    {
        slider.value = EnemyFollowingReference.Health;
    }
    public void SetHealthOnLevelStart()
    {
        slider.maxValue = EnemyFollowing.MaxHealth;
        slider.value = EnemyFollowing.MaxHealth;

    }
    public void SetHealthOnLevelUp()
    {
        slider.maxValue = EnemyFollowing.MaxHealth;
        slider.value = EnemyFollowingReference.Health;

    }

}
