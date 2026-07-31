using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    public BoxCollider2D playerCollider;
    public Animator playerAnimation;

    private void Update()
    {
        playerAnimation.SetBool("isMoving", Input.GetAxisRaw("Horizontal") != 0);
    }
}
