using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName= "Dialogo")]

public class DialogoSO : ScriptableObject
{
    // para que sea un scriptableObject

    [TextArea(5,10)]

    public string[] frases;
    public float tiempoEntreLetras;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
