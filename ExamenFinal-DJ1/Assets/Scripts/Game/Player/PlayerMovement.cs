using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float speed = 3f;
    public bool isGrounded = false;
    private Rigidbody2D body;
    // Update is called once per frame
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {

        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetFloat("Horizontal", -1f);
            Vector3 horizontal = new Vector3(-1f, 0.0f, 0.0f);
            transform.position = transform.position + horizontal * Time.deltaTime * speed;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetFloat("Horizontal", 1f);
            Vector3 horizontal = new Vector3(1f, 0.0f, 0.0f);
            transform.position = transform.position + horizontal * Time.deltaTime * speed;
        }
        else 
        {
            animator.SetFloat("Horizontal", 0f);
        }
        Jump();


        
    }
    void Jump() 
    {
        if (Input.GetKey(KeyCode.UpArrow) && isGrounded==true) 
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 3f), ForceMode2D.Impulse);
        }
    }
}
