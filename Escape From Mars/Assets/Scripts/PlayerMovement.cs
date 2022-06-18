using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed=1f;
    Animator animator;
    Rigidbody2D rb;
    float scaleX;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        scaleX = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))*speed;
        rb.velocity = velocity;
        animator.SetFloat("Speed",velocity.sqrMagnitude);

        //flip animation
        Vector3 scale = transform.localScale;
        scale.x = scaleX * (velocity.x>=0? 1:-1);
        transform.localScale = scale;
    }
}
