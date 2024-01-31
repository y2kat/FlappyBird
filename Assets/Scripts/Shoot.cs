using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }

    //private void Shoot(InputAction.CallbackContext context)
    //siempre que se delega, debo de llamar a un contexto
    //if (context.action.activeControl != null && canShoot)
    //{
    // string inputKey = context.control.name;
    //switch (inputKey)
    //{ case "downArrow": Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0,0,-90)); break;}
    //así para cada caso/tecla Y SE ROTA EN EL EJE Z. El Quaternion.identity es el 0,0,0.
    //}
}
