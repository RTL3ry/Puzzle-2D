using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class WinTrigger : MonoBehaviour
{
  public GameObject winText; //declarar variable panel nuevo
 public void OnTriggerEnter2D(Collider2D collider2D)
 {
    Debug.Log("se tocan ");
    if(collider2D.CompareTag("Player"))
    {
      winText.SetActive(true);  
    }// activar Panel nuevo
    
  
 }
}
