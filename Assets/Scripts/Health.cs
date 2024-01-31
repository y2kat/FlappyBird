using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int vidaInicial = 100;
    private int vidaActual;

    void Start()
    {
        vidaActual = vidaInicial;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el personaje colisiona con un enemigo
        if (collision.collider.CompareTag("Enemigo"))
        {
            // Reducir la vida del personaje
            TomarDa�o(50);
            Debug.Log("AUCHHHHH");
        }
    }

    private void TomarDa�o(int cantidad)
    {
        // Reducir la vida del personaje
        vidaActual -= cantidad;

        // Verificar si el personaje a�n tiene vida
        if (vidaActual <= 0)
        {
            Morir();
        }
    }

    private void Morir()
    {
        Debug.Log("Dedddd");
    }
}
