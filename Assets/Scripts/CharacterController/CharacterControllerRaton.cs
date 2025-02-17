using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerRaton : MonoBehaviour

{
    public float moveSpeed = 5f; // Velocidad de movimiento
    private Animator animator; // Referencia al componente Animator
    private Vector3 targetPosition; // Posici�n objetivo
    private bool isMoving = false; // Estado de movimiento

    void Start()
    {
        animator = GetComponent<Animator>(); // Obtener el componente Animator
    }

    void Update()
    {
        // Detectar clic del rat�n
        if (Input.GetMouseButtonDown(0))
        {
            // Crear un rayo desde la c�mara hacia la posici�n del rat�n
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Comprobar si el rayo colisiona con algo
            if (Physics.Raycast(ray, out hit))
            {
                // Establecer la posici�n objetivo al punto de colisi�n
                targetPosition = hit.point;
                isMoving = true; // Cambiar el estado a moviendo
            }
        }

        // Mover el personaje hacia la posici�n objetivo
        if (isMoving)
        {
            // Calcular la direcci�n hacia la posici�n objetivo
            Vector3 direction = (targetPosition - transform.position).normalized;

            // Mover el personaje
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Actualizar el Animator
            animator.SetFloat("Speed", direction.magnitude);

            // Comprobar si ha llegado a la posici�n objetivo
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                isMoving = false; // Detener el movimiento
                animator.SetFloat("Speed", 0); // Establecer la velocidad a 0 (Idle)
            }
        }

        // Controlar ataque
        if (Input.GetButtonDown("Fire1") && !isMoving)
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }
}

