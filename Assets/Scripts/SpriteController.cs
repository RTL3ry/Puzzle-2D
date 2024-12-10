using UnityEngine;
using UnityEngine.UI;


public class SpriteController : MonoBehaviour
{
    public GameObject Pausa;
    public Sprite pauseSprite;
    public Sprite playSprite;
    // Start is called before the first frame update
    void Start()
    {
        Pausa = gameObject;
        //accion
        Sprite Load(string imageName, string spriteName)
        {
            Sprite[] all = Resources.LoadAll<Sprite>(imageName); //tenemos la mama con las dos imagenes 
            foreach (var s in all) // se pone en plan creizi a buscarlas
            {
                if (s.name == spriteName)// si la s.imagen es igual a sprite
                {
                    return s; //nos devuelve el sprite 
                }
            } 
            return null; // se deja de poner creizi y se para
        }
        // a quien se le hace la accion

        playSprite = Load("play-pause", "Play"); //sprite de play
        pauseSprite = Load("play-pause", "Pausa"); // sprite de pausa


        //nombre variable = carga (la imagen x, la parte x);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            Pausa.GetComponent<Image>().sprite = playSprite;
        }
        else
        {
            Pausa.GetComponent<Image>().sprite = pauseSprite;
        }
    }
}
