using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;

    private bool jump = false;
    
    public string Tag;
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, body.velocity.y);
    if(jump == true){
        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, speed);
            jump = false;
        }
    }}

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == Tag){
            jump = true;
        }
    }
}
