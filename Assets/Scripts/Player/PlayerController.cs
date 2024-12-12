using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerb; //declaramos el rigidbody 2d
    void Start()
    {
        playerb = GetComponent<Rigidbody2D>(); // le damos el componente rb 2d a el player

    }

    public void Update()
    {
       
    }

   
}
