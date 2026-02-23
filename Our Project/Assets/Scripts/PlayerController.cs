using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;

    private RigidBody2D playerRb;
    private Vector2 moveVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<RigidBody2d>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
