using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed;



    private void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(xInput, yInput);
        if (movement.magnitude > 0)
        {
            movement.Normalize();
        }

        transform.Translate(movement * speed * Time.deltaTime);
    }



}
