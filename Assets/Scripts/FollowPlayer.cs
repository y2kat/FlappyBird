using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float velocidad = 5f;
    public Transform jugador;

    //Buscar singleton y degisnpatterns!!!!

    void Start()
    {
        // Inicia el proceso de generar enemigos cada cierto tiempo
        InvokeRepeating("GenerarEnemigo", 2f, 5f);
    }

    void Update()
    {
        // Verificar si el jugador existe
        if (jugador != null)
        {
            // Calcular la dirección hacia el jugador
            Vector2 direccion = (jugador.position - transform.position).normalized;

            // Mover el enemigo hacia el jugador
            transform.Translate(direccion * velocidad * Time.deltaTime);
        }
    }

    void GenerarEnemigo()
    {
        // Crea una instancia del enemigo en una posición aleatoria
        Vector2 posicionAleatoria = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        Instantiate(gameObject, posicionAleatoria, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el enemigo colisiona con una bala
        if (collision.collider.CompareTag("Bala"))
        {
            // Destruir el enemigo al colisionar con una bala
            Destroy(gameObject);
        }
    }
}
