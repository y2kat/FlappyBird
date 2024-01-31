using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 10f;
    public float fuerzaRetroceso = 5f;
    //serializar mis variables y ponerlas privadas!!

    private void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si la bala colisionó con un enemigo
        if (other.CompareTag("Enemigo"))
        {
            // Aplicar fuerza de retroceso al enemigo
            AplicarRetroceso(other.gameObject);

            // Destruir la bala
            Destroy(gameObject);
        }
    }

    private void AplicarRetroceso(GameObject enemigo)
    {
        // Calcular la dirección desde el enemigo hacia la bala
        Vector2 direccion = (enemigo.transform.position - transform.position).normalized;

        // Obtener el componente Rigidbody2D del enemigo
        Rigidbody2D rbEnemigo = enemigo.GetComponent<Rigidbody2D>();

        // Aplicar fuerza de retroceso al enemigo
        rbEnemigo.AddForce(direccion * fuerzaRetroceso, ForceMode2D.Impulse);
    }
}
