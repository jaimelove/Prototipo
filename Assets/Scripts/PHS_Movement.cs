using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
    private bool wasLandedLastFrame = true;
    private float landingTimer = 0f;
    private bool isGrounded = true;

    private Camera camera;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    private void Update()
    {
        CheckInput();
        DoJump();
        CheckShoot();
        DoShoot();
        CheckLanding();
        DoLandingTimer();
        CheckGrounded();
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
        if (movementInput.y > 0.2f && isGrounded)
        {
            Debug.Log("jump");
            wasLandedLastFrame = false;
            landingTimer = 0.5f;
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Abs(movementInput.y * jumpStrength));
            camera.DORestart();
            camera.DOShakePosition(1f, 0.5f);
            //transform.DOPunchScale(new Vector3(0f, 0.3f, 0f), 5f);
        }
    }

    private void CheckLanding()
    {
        if (wasLandedLastFrame == false && isGrounded && landingTimer <= 0f)
        {
            // just landed after jump
            Debug.Log("landed");
            wasLandedLastFrame = true;
            camera.DORestart();
            camera.DOShakePosition(1f, 1f);
        }
    }

    private void DoLandingTimer()
    {
        if (landingTimer <= 0f)
        {
            Debug.Log("landing timer is 0");
            landingTimer = 0f;
        }
        else
        {
            //Debug.Log(landingTimer);
            landingTimer -= Time.deltaTime;
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

    private void CheckGrounded()
    {
        Debug.Log("isgrounded");
        isGrounded =  Physics2D.Raycast(transform.position, -transform.up, groundCheckRayLength, groundLayer);
    }
}
