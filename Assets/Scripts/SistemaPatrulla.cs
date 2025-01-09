using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SistemaPatrulla : MonoBehaviour
{
    [SerializeField] private Enemy main;
    [SerializeField] private Transform ruta;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private float velocidadPatrulla;
    //private NavMeshAgent agent;

    List<Vector3> listadoPuntos = new List<Vector3>();

    private Vector3 destinoActual; //marca a donde tiene que ir 
    // Start is called before the first frame update
    private void Awake()
    {
        main.Patrulla1 = this;
        //agent = GetComponent<NavMeshAgent>;
        foreach (Transform punto in ruta)
        {
            listadoPuntos.Add(punto.position);
        }
        //CalcularDestino();
    }
    private void Start()
    {
        main.Patrulla1 = this;
    }

    private void OnEnable()
    {
        //indiceDestinoActual = -1;
        agent.speed = velocidadPatrulla;
        StartCoroutine(PatrullarYEsperar());

        
    }

    private IEnumerator PatrullarYEsperar()
    {
        while (true)
        {
            CalcularDestino(); //1.Calcular el destino 
            agent.SetDestination(destinoActual); //2.Se te marca el destino

            yield return new WaitUntil( () => !agent.pathPending  && agent.remainingDistance <= 0.2f);

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
        if (other.CompareTag("Player"))
        {
            main.ActivaCombate(other.transform);
            this.enabled = false; //deshabilitar patrulla
            StopAllCoroutines();//paro corrutinas

        }
    }

}
