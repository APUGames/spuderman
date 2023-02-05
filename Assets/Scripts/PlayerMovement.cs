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
    public GameObject sprite;

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
            transform.position += new Vector3(horizontalDirection, 0, 0) * Time.deltaTime * moveSpeed;
        }
        else if (horizontalDirection == 0)
        {
            animator.enabled = false;
        }
        else
        {
            if (horizontalDirection < 0)
            {
                sprite.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
            else if (horizontalDirection > 0)
            {
                sprite.transform.localScale = new Vector3(1f, 1f, 1f);
            }
            transform.position += new Vector3(horizontalDirection, 0, 0) * Time.deltaTime * moveSpeed;
            animator.enabled = true;
        }
    }
}
