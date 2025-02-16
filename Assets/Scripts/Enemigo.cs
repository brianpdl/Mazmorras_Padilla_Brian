using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private Transform ruta;

    private NavMeshAgent agent;

    List <Vector3> listadoPuntos = new List <Vector3>();

    private Vector3 destinoActual; //marca el destino que tiene que ir 
    private int indiceRutaActual = -1; //marca el indice del nuevo punto al cual patrullar.

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
         
        //esto para que vaya recorriendo todos los puntos que tiene mi ruta asignada
        foreach (Transform punto in ruta)
        {
            listadoPuntos.Add(punto.position);

        }
    }

   

    private void CalcularDestino()
    {

        indiceRutaActual++;
        //count pa listas, Length pa arrays
        if(indiceRutaActual >= listadoPuntos.Count)
        {
            //si no hay puntos de vuelta al punto 0 
            indiceRutaActual = 0;
        }
        destinoActual = listadoPuntos[indiceRutaActual];
    }

}
