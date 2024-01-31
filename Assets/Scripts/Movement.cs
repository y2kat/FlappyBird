using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    public float velocidad = 5f;

    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular la dirección del movimiento
        Vector2 direccion = new Vector2(movimientoHorizontal, movimientoVertical).normalized;
        //Vector3 direccion = new Vector3(playerInputActions.Standard.Move.ReadValue<Vector2>().x,playerInputActions.Standard.Move.ReadValue<Vector2>().y)
        //no se usa en transform, sino el AddForce para que sea continuo el movimiento en el espacio
        //cualquier cosa con física y rigidbody va en FixedUpdate

        // Calcular la posición del siguiente frame
        Vector2 posicionSiguiente = (Vector2)transform.position + direccion * velocidad * Time.deltaTime;

        // Mover el personaje
        transform.position = new Vector3(posicionSiguiente.x, posicionSiguiente.y, transform.position.z);

        //la forma alternativa/nueva sería playerInputActions = new PlayerInputActions();
        //donde tengo mi variable y le creo un objeto que le asigno a la variable, ésta se debe poner en el AWAKE
        //en START se debe activar éstos de la siguiente sofrma: playerInputActions.Enable();
    }
}
