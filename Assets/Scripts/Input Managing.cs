using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManaging : MonoBehaviour
{
    
    public Vector2 InputAxis { get; private set; }
    public static InputManaging instance;
    
    public PlayerStats PlayerStatsReference;
    [SerializeField]
    public EnemySpawning EnemySpawningReference;
    [SerializeField]
    public Vector2 PlayerPosReference;
    private void Awake()
    {

        instance = this;
        EnemySpawningReference = FindFirstObjectByType<EnemySpawning>();
        PlayerPosReference = EnemySpawningReference.PlayerPos;
        

    }
    public void OnMove(InputAction.CallbackContext callback)
    {
        InputAxis = callback.ReadValue<Vector2>();
    }


    public void OnMouse(InputAction.CallbackContext context)
    {
        if (context.started)
        { 
            PlayerStatsReference.PlayerAttacks(PlayerPosReference);
            print(PlayerPosReference);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosReference = EnemySpawningReference.PlayerPos;

    }
}
