using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // declaramos la velocidad
    private Rigidbody2D playerb; //declaramos el rigidbody 2d
    private Vector2 _input;
    public float inputMovimiento;
    void Start()
    {
        playerb = GetComponent<Rigidbody2D>(); // le damos el componente rb 2d a el player
        //Life = playerStats.MaxLife;
    }
    void ProcesarMovimiento()
    {
        {
            inputMovimiento = Input.GetAxis("Horizontal");
            playerb.velocity = new Vector2(inputMovimiento * speed, playerb.velocity.y);
            //aqui se añade movida de animaciones
            if (inputMovimiento < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            else 
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }

    public void Update()
    {
       
    }


    /*private void FixedUpdate()
    {
        IsGrounded = gc.IsGrounded();//pasamos la funcion anterior a traves de la funcion, esto hace que sean iguales a los ojos de unity
        if (Input.GetKey("d"))
        {
            playerb.AddForce(transform.right * speed);
        }
        else if (Input.GetKey("a"))
        {
            playerb.AddForce(transform.right * -speed);
        }
        else if (Input.GetKey("w"))
        {
            playerb.AddForce(transform.up * speed);
        }
        else if (Input.GetKey("s"))
        {
            playerb.AddForce(transform.up * -speed);
        }
        if (Input.GetKey("space") && gc.IsGrounded())
        {
            playerb.AddForce(transform.up * speedJump);
            Debug.Log("NpcSaltando");
        }
    }*/
   
}
