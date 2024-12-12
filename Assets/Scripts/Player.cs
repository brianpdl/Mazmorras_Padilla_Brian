using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private float distanciaInteraccion;

    private NavMeshAgent agent;
    private Camera cam;

    private NPC npcActual;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1)
        {
            Movimiento();

        }

        if (npcActual)
        {
            if(!agent.pathPending && agent .remainingDistance <= agent.stoppingDistance)
            {
                npcActual.Interactuar(this.transform);
                npcActual = null;
                agent.isStopped = true;
                agent.stoppingDistance = 0;

            }

        }
       //trazar un raycast desde la camara a la posicion del rayo
       //
       //if(ultimoClick && ultimoClick.TryGetComponent(out NPC npc))
        {
            agent.stoppingDistance = distanciaInteraccion;
            {
                //if(!agent.pathPending)
            }
        }
        

        
    }
    private void Movimiento()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.TryGetComponent(out NPC npc))
                {
                    npcActual = npc;
                    agent.stoppingDistance = distanciaInteraccion;

                }
                agent.SetDestination(hit.point);
                
            }    

        } 

    }
}
