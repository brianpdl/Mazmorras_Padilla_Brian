using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Outline outline;
    [SerializeField] private float tiempoRotacion;
    // Start is called before the first frame update
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interactuar(Transform interactuador)
    {
        Debug.Log("Hola1");
        transform.DOLookAt(interactuador.position, tiempoRotacion, AxisConstraint.Y);
    }
    private void OnMouseEnter()// cunado pasamos x encima 
    {        
        outline.enabled = true;
    }

    private void OnMouseExit()//se quita el raton
    {       
        outline.enabled = false;
    }


}
