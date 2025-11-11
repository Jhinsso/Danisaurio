using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Para el botón

public class Gameover : MonoBehaviour
{
    [SerializeField] private GameObject Personaje;
    [SerializeField] private GameObject imagenPerder; // Panel de Game Over
    [SerializeField] private GameObject botonRetry; // El botón de reintentar (como GameObject)
    
    
    
    private bool juegoTerminado = false;

    void Start()
    {
        // Asegurarnos que el panel y el botón estén ocultos al inicio
        imagenPerder.SetActive(false);
        botonRetry.SetActive(false);
        
        // Configurar el botón para que llame a ReiniciarJuego cuando se presione
        Button btnComponent = botonRetry.GetComponent<Button>();
        if (btnComponent != null)
        {
            btnComponent.onClick.AddListener(ReiniciarJuego);
        }
    }

    void Update()
    {
        // Verificar si el personaje está desactivado y aún no ha terminado el juego
        if (!Personaje.activeInHierarchy && !juegoTerminado)
        {
            MostrarGameOver();
        }
    }

    void MostrarGameOver()
    {
        juegoTerminado = true;
        imagenPerder.SetActive(true);
        botonRetry.SetActive(true); // Mostrar el botón
        Time.timeScale = 0f; // Pausar el juego 
    }

    public void ReiniciarJuego()
    {
        // Reanudar el tiempo y recargar la escena actual
        GameManager.instance.puntuacionActual = 0; // esto es para que el marcador puntuacion actual se reinicie.
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}