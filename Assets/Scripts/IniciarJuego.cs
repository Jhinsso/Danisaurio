using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciaryquitar : MonoBehaviour
{
    public void Jugar() //para jugar.
    {
        SceneManager.LoadScene("Juego");//Para cargar una escena entre los () la escena que queremos cargar.
    }

    public void Salir() //para salir.
    {
        Application.Quit(); // para quitar el juego.
    }
}