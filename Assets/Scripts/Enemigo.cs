using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigo : MonoBehaviour
{

    [SerializeField] private Transform ruta;

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
    }

    //private IEnumerator PatrullarYEsperar()
    
    void Start()
    {
        //StartCoroutine(PatrullarYEsperar));
    }

    private void  CalcularDestino()
    {

    }
}
