using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class WinTrigger : MonoBehaviour
{
  public GameObject winText; //declarar variable panel nuevo
 public void OnTriggerEnter(Collider collider)
 {
    Debug.Log("se tocan ");
    if(collider.CompareTag("Player"))
    {
      winText.SetActive(true);
    }// activar Panel nuevo
    
  
 }
}
