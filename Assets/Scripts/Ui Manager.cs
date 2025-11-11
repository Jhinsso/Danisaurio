using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActualTexto;
    [SerializeField] TMP_Text mejorPuntuacionTexto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntuacionActualTexto.text = GameManager.instance.puntuacionActual.ToString();
        mejorPuntuacionTexto.text = GameManager.instance.mejorPuntuacion.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionActualTexto.text = GameManager.instance.puntuacionActual.ToString();
        mejorPuntuacionTexto.text = GameManager.instance.mejorPuntuacion.ToString();
    }
}
