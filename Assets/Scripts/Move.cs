using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int hearth = 5;
    private float horizontalInput;
    private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private float wallJumpCooldown;
    private float jumpPower;
    public bool Attack()
    {
        return horizontalInput == 0 && isGrounded() && !onWall();
    }
    //kiem tra o tren mat dat
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }
    // kiem tra o tren tuong
    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycastHit.collider != null;
    }
    //khoi tao cac bien
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        speed = 4f;
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        jumpPower = 7f;
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //quay trai va quay phai
        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        //chinh cac animation khi nhay va chay
        anim.SetBool("run", horizontalInput != 0);
        
        anim.SetBool("grounded", isGrounded());
        //kiem tra thoi gian giua 2 lan nhay
        if (wallJumpCooldown > 0.2f)
        {
            body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
            if (onWall() && !isGrounded())
            {
                //neu o tren tuong chinh trong luc = 0
                body.gravityScale = 0;
                body.velocity = Vector2.zero;
            }
            else
            {
                //neu o duoi dat chinh trong luc = 1
                body.gravityScale = 1;
            }
            //nhay khi bam nut space
            if (Input.GetKey(KeyCode.Space))
            {
                // kiem tra neu o duoi dat thi nhay voi luc = jumpPower
                if (isGrounded())
                {
                    body.velocity = new Vector2(body.velocity.x, jumpPower);
                    anim.SetTrigger("jump");
                }
                else if (onWall() && !isGrounded())
                {
                    //treo len tuong
                    if (horizontalInput == 0)
                    {
                        //-Mathf.Sign(transform.localScale.x = 1 khi o ben phai va -1 khi o ben trai
                        body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                        //tranh de nhan vat khi nhay khoi tuong bi xoay vong vong
                        transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                    }
                    else
                    {
                        //cho nhan vat treo tuong
                        body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
                    }

                    wallJumpCooldown = 0;
                }
            }
        }
        else
        {
            wallJumpCooldown += Time.deltaTime;
        }
    }
}
