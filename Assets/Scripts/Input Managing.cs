using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManaging : MonoBehaviour
{
    
    public Vector2 InputAxis { get; private set; }
    public static InputManaging instance;
    public bool AttackPressed = false;
    
    public PlayerStats PlayerStatsReference;
    private void Awake()
    {
        instance = this;
       

    }
    public void OnMove(InputAction.CallbackContext callback)
    {
        InputAxis = callback.ReadValue<Vector2>();
    }


    public void OnMouse(InputAction.CallbackContext context)
    {
        if (context.started)
        { 
        
            PlayerStatsReference.PlayerAttacks();
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
