using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalDirection;
    private Rigidbody2D rb2d;

    [SerializeField]
    public Animator animator;

    public RootGrappling Grappler;

    public float moveSpeed = 5f;
    public float jumpForce = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalDirection = Input.GetAxisRaw("Horizontal");


        if (Grappler.enabled)
        {
            animator.enabled = false;
        }
        else if (horizontalDirection == 0)
        {
            animator.enabled = false;
        }
        else
        {
            transform.position += new Vector3(horizontalDirection, 0, 0) * Time.deltaTime * moveSpeed;
            animator.enabled = true;
        }
    }
}
