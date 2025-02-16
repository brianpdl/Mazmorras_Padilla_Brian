using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour

{
    public float moveSpeed = 5f; // Velocidad de movimiento
    private Vector3 targetPosition; // Posición objetivo
    private bool isMoving = false; // Estado de movimiento

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
            // Mover el personaje hacia la posición objetivo
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Comprobar si ha llegado a la posición objetivo
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                isMoving = false; // Detener el movimiento
            }
        }
    }
}

