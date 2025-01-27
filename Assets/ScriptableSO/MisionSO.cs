using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Misión")]
public class MisionSO : ScriptableObject
{
    public string ordenInicial;// recoge...
    public string ordenFinal; //vuelve hablar con..

    public bool repetir; //si la mision se tiene que repetir, ej: coleccionables (setas)
    public int repeticionesTotales; //para las veces que tienes que repetirlo (ej 5, pues se hacen 5veces)

    public int estadoActual;

    public int indiceMision; //un identificador de misiones UNICO.
}
