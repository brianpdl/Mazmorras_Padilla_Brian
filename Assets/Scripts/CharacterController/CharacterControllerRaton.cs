using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerRaton : MonoBehaviour

{
    public float moveSpeed = 5f; // Velocidad de movimiento
    private Animator animator; // Referencia al componente Animator
    private Vector3 targetPosition; // Posición objetivo
    private bool isMoving = false; // Estado de movimiento

    void Start()
    {
        animator = GetComponent<Animator>(); // Obtener el componente Animator
    }

    void Update()
    {
        // Detectar clic del ratón
        if (Input.GetMouseButtonDown(0))
        {
            // Crear un rayo desde la cámara hacia la posición del ratón
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Comprobar si el rayo colisiona con algo
            if (Physics.Raycast(ray, out hit))
            {
                // Establecer la posición objetivo al punto de colisión
                targetPosition = hit.point;
                isMoving = true; // Cambiar el estado a moviendo
            }
        }

        // Mover el personaje hacia la posición objetivo
        if (isMoving)
        {
            // Calcular la dirección hacia la posición objetivo
            Vector3 direction = (targetPosition - transform.position).normalized;

            // Mover el personaje
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Actualizar el Animator
            animator.SetFloat("Speed", direction.magnitude);

            // Comprobar si ha llegado a la posición objetivo
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

