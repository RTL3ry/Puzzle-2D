using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{

    public GameObject sonidoSeleccionar;
    public GameObject sonidoClick;
  
    void Start()
    {
       
    }

 
    void Update()
    {
        
    }

    public void BotonSonSelec()
    {
        Instantiate(sonidoSeleccionar);
    }

    public void BotonSonClick()
    {
        Instantiate(sonidoClick);
    }
}
