using UnityEngine;

public class Enemigo1 : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 2f; // velocidad de movimiento hacia la izquierda

    private float leftLimit;
    public Spawner spawner; // referencia al spawner de enemigos

    void Start()
    {
       

        // Calcular el límite izquierdo de la cámara (en Vector2)
        Camera cam = Camera.main;
        Vector2 bordeIzquierdo = cam.ScreenToWorldPoint(new Vector2(0, Screen.height / 2));
        leftLimit = bordeIzquierdo.x - 1f; // un pequeño margen fuera de pantalla
    }

    void Update()
    {
        // Movimiento hacia la izquierda (en Vector2)
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);

        // Si el enemigo salió del borde izquierdo de la pantalla
        if (transform.position.x < leftLimit)
        {
            // Destruir al enemigo
            Destroy(gameObject);

            if (spawner != null)
            {
                // Notificar al spawner que este enemigo ha sido destruido
               Spawner spawnerScript = spawner.GetComponent<Spawner>();

                // Si el spawner existe, llamar a SpawnEnemy para crear un nuevo enemigo
                if (spawnerScript != null)
                 {
                      spawner.SpawnEnemy();
                }
            }
        }
    }
}
