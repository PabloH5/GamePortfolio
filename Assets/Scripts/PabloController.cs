using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PabloController : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Set In Inspector")]
    public Vector2 speed = new Vector2(1f, 1f);

    private Vector2 movement;
    private Rigidbody2D rigidBody2D;
    private Animator animatorController;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        animatorController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        movement = new Vector2(inputX * speed.x, 0);

        if (inputX < 0)
        {
            this.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (inputX > 0)
        {
            this.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void FixedUpdate()
    {
        rigidBody2D.velocity = movement;
        if (rigidBody2D.velocity.x != 0)
        {
            animatorController.SetBool("isWalking", true);
        }
        else { animatorController.SetBool("isWalking", false); }
    }
}
