using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour

{
    public float moveSpeed = 5f; // Velocidad de movimiento
    private Vector3 targetPosition; // Posici�n objetivo
    private bool isMoving = false; // Estado de movimiento

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
            // Mover el personaje hacia la posici�n objetivo
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Comprobar si ha llegado a la posici�n objetivo
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                isMoving = false; // Detener el movimiento
            }
        }
    }
}

