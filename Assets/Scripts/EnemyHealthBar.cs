using UnityEngine;
using UnityEngine.UI;
public class EnemyHealthBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider slider;
    public EnemyFollowing EnemyFollowingReference;    
    void Awake()
    {
        slider = GetComponentInChildren<Slider>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyFollowingReference = GetComponentInParent<EnemyFollowing>();
        
        
    }
    public void SetHealthOnChange()
    {
        slider.value = EnemyFollowingReference.Health;
        print("enemy hit");
    }
    public void SetHealthOnLevelStart()
    {
        slider.maxValue = EnemyFollowing.MaxHealth;
        slider.value = EnemyFollowingReference.Health;

    }
    public void SetHealthOnLevelUp()
    {
        slider.maxValue = EnemyFollowing.MaxHealth;
        slider.value = EnemyFollowingReference.Health;

    }

}
