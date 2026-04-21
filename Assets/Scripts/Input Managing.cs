using UnityEngine;
using UnityEngine.InputSystem;

public class InputManaging : MonoBehaviour
{
    public Vector2 InputAxis { get; private set; }
    public static InputManaging instance;
    private void Awake()
    {
        instance = this;

    }
    public void OnMove(InputAction.CallbackContext callback)
    {
        InputAxis = callback.ReadValue<Vector2>();
    }
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
