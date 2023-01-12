using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHS_Movement : MonoBehaviour
{
    [SerializeField] private float baseMovementSpeed;
    [SerializeField] private float runMultiplier;

    [SerializeField] private float jumpStrength;
    [SerializeField] private float groundCheckRayLength = 0.6f;

    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private GameObject bulletPrefab;

    private Rigidbody2D rb;

    private Vector2 movementInput = new Vector2();
    private bool isSprinting = false;
    private bool isShooting = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        CheckInput();
        DoJump();
        CheckShoot();
        DoShoot();
    }

    private void FixedUpdate()
    {
        DoMovement();
    }

    private void CheckInput()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }
    }

    private void CheckShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            isShooting = true;
        else
            isShooting = false;
    }

    private void DoShoot()
    {
        if (isShooting)
        {
            GameObject currentBullet = Instantiate(bulletPrefab, transform.position + (transform.up * 1f), transform.rotation);
            currentBullet.GetComponent<Rigidbody2D>().AddForce(movementInput * 50f, ForceMode2D.Impulse);
        }
    }

    private void DoJump()
    {
        if (movementInput.y > 0.2f && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Abs(movementInput.y * jumpStrength));
        }
    }

    private void DoMovement()
    {
        float moveSpeed = baseMovementSpeed;

        if (isSprinting)
        {
            moveSpeed *= runMultiplier;
        }

        rb.velocity = new Vector2(movementInput.x * moveSpeed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.Raycast(transform.position, -transform.up, groundCheckRayLength, groundLayer);

    }
}
