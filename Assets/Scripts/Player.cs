using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private NewInput inputActions;

    [SerializeField] private float speed;

    private PoolScript bulletPool;
    private Rigidbody2D rb;

    private void Awake()
    {
        inputActions = new NewInput();
        bulletPool = GameObject.Find("BulletPool").GetComponent<PoolScript>(); //se hace referencia al script y el objeto específico!!
    }

    private void Start()
    {
        inputActions.Enable();
        rb = GetComponent<Rigidbody2D>();

        inputActions.NewStandard.Shooting.performed += Shoot;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Debug.Log(inputActions.NewStandard.Movement.ReadValue<float>());
        Vector2 direction = new Vector2(0, inputActions.NewStandard.Movement.ReadValue<float>()).normalized;
        rb.AddForce(direction * speed);
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        GameObject bullet = bulletPool.RequestObject(); //
        bullet.SetActive(true);
        bullet.transform.position = transform.position;
    }
}
