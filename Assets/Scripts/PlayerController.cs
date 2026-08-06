using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    public BoxCollider2D playerCollider;
    public Rigidbody2D playerPhysics;
    public Animator playerAnimation;

    [Header("Parameters")]
    public float moveSpeed = 5f;
    
    private float player_x, player_y;

    private void Awake()
    {
        
    }

    private void FixedUpdate()
    {
        player_x = Input.GetAxisRaw("Horizontal");
        playerPhysics.linearVelocityX = player_x;
    }

    private void Update()
    {
    }


}
