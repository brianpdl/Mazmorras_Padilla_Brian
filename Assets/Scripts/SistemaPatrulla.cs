using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPatrulla : MonoBehaviour
{

    [SerializeField] private Transform ruta;
    [SerializeField]                                                    

    //private NavMeshAgent agent;

    List<Vector3> listadoPuntos = new List<Vector3>();

    private Vector3 destinoActual; //marca a donde tiene que ir 
    // Start is called before the first frame update
    private void Awake()
    {
        //agent = GetComponent<NavMeshAgent>;
        foreach (Transform punto in ruta)
        {
            listadoPuntos.Add(punto.position);
        }
        //CalcularDestino();
    }

    //private IEnumerator PatrullarYEsperar()
    void Start()
    {
        StartCoroutine(PatrullarYEsperar());
    }

   
    private IEnumerator PatrullarYEsperar()
    {
        while (true)
        {
            CalcularDestino(); //1.Calcular el destino 
            //agent.SetDestiantion(destinoActual); //2.Se te marca el destino

            //yield return new WaitUntil( () => !agent.pathPending  && agent.remainingDistance <= 0.2f);

            yield return new WaitForSeconds(Random.Range (0.5f, 1.5f));
        }
    }
    // Start is called before the first frame update

    // Update is called once per frame
    private void CalcularDestino()
    {
        //if(indiceRutaActual >= listadoPuntos.Count)
        //{
            //IndiceRutaAcutal = 0;
        //}
        //destinoActual = listadoPuntos[IndiceRutaActual];
    }

    private void OnTriggerEnter(Collider other)
    {
        //1.mirar si lo que entra a mi trigger es el player
        //2.si es asi, parar todas las corrutinas
        //3.desactivar este sript
        //
    }
}
