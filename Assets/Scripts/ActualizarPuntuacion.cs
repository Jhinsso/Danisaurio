using UnityEngine;

public class PuntosControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) // esto es el ontrigger que hay que poner para que funciones el script.
    {
        if (other.transform.tag == "Enemigo") // si other,t,t es el objeto es Enemigo.
        {
            GameManager.instance.ActualizarPuntuacion();//el game manager actualiza la puntuacion.
        }
    }
}
