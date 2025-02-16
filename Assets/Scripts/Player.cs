using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private float distanciaInteraccion;

    private NavMeshAgent agent;
    private Camera cam;

    //Aqui guardo la info del NPC actual con el que voy a hablar.
    private NPC npcActual;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }

    void Update()
    {
        Movimiento();

        if (npcActual)
        {
            if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            {
                npcActual.Interactuar(this.transform);
                npcActual = null;
                agent.isStopped = true;
                agent.stoppingDistance = 0;
            }
        }

    }

    

    // Update is called once per frame     
    private void Movimiento()
    {
        //Trazar un Raycast desde la camara a la posicion del raton 

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit) )
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.TryGetComponent(out NPC npc))
                {
                    // en ese caso , ese NPC es el actual 
                    npcActual = npc;

                    //ahora la distancia de parada es la interaccion (pararme a X metros del NPC)
                    agent.stoppingDistance = distanciaInteraccion;
                }

                agent.SetDestination(hit.point);
            }
        }
        

        
    }
    
}
