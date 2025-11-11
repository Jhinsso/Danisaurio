using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlPersonaje : MonoBehaviour
{
    [SerializeField] Rigidbody2D RigiBody;
    [SerializeField] Animator animator;
    [SerializeField] float alturaSalto;
    [SerializeField] private GameObject Personaje;
    void Start()
    {
        RigiBody = GetComponent<Rigidbody2D>();//Agarra el componente rigibody
        animator = GetComponent<Animator>();//Agarra el componente animator.
    }

    void Update()
    {
       
    }
    public void Salto(InputAction.CallbackContext value) //pa darle valor al salto.
    {
       
        if (value.started)
        {
            animator.SetBool("Salto", true);//Esto es para la ida.
            RigiBody.linearVelocity = Vector2.zero;//lo frena 
            RigiBody.AddForce(Vector2.up * alturaSalto);//lo lanza
        }
      
        
    }
    private void OnCollisionEnter2D(Collision2D collision) // esto es para que cuando toque el suelo empieze a correr de nuevo.
    {
        if (collision.transform.tag == "Suelo")// si la collision es el tag suelo.
        {
            animator.SetBool("Salto", false);//pasa el salto a flase lo que hace volver la animacion.
        } 
           if (collision.transform.tag == "Enemigo")
            {
            Personaje.SetActive(false);
            } 
        }
    }

