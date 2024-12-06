using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("Puzzle", LoadSceneMode.Single); //carga la escena principal del juego
    }
    public void GameQuit()
    {
        Application.Quit(); //cerrar juego
        Debug.Log("Se apagó");
    }
}
