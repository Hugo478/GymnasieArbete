using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed;



    private void Update() {
        
        body.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, body.velocity.y);

        if(Input.GetKey(KeyCode.Space)){
            body.velocity = new Vector2(body.velocity.x, speed);
        }

    }



}
