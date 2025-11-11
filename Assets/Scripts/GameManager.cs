using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]  public int  puntuacionActual;
    [SerializeField] public int mejorPuntuacion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start () //Awake antes del start .
    {
        
    }
    //las lineas de codigo de la camara en el late update
    // Update is called once per frame
    void Update()
    {
        mejorPuntuacion = PlayerPrefs.GetInt("MejorPuntuacion");
    }
    public void ActualizarPuntuacion()
    {
        puntuacionActual++; // Esto para sumar
        if(puntuacionActual > mejorPuntuacion ) // si la puntuacion actual es mas que mejor puntuacion.
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("MejorPuntuacion", mejorPuntuacion);
        }
    }
}
