using UnityEngine;
using UnityEngine.InputSystem;

public class jump : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] 
    InputAction jumpaction = new InputAction( type : InputActionType.Button);
    public float jumpStrength = 7;
    public logicScript logic;
    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
        jumpaction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpaction.WasPressedThisFrame() && isAlive)
        {
            Debug.Log("jumped");
            if (rb.linearVelocityY < 0)
            {
                rb.linearVelocityY = 0;
            }
            rb.linearVelocityY += jumpStrength;

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided with pipe");
        logic.GameOver();
        isAlive = false;
    }
}
