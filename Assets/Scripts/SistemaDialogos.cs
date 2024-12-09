using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDialogos : MonoBehaviour
{
    [SerializeField] private GameObject marcos;
    //[SerializeField] private TMP_Text textoDialogo; añadir el tmp texto
    private bool escribiendo;
    private bool indiceEscribiendo;

    public static SistemaDialogos sistema;

    private void Awake()
    {
        if(sistema == null)
        {
            sistema = this;

            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IniciarDialogo()
    {
        marcos.SetActive(true);
    }
    //private IEnumerator EscribirFrase()
    //{
        //textoDialogo.text = "";
        //char[] fraseEneLetras = dialogoActual.frases[indiceFraseActual].ToCharArray();
        //foreach (char letra in fraseEneLetras)
        //{
            //textoDialogo.text += letra;
            //yield return new WaitForEndOfFrame(dialogoActual.tiempoEntreLetras);
        //}
    //}

    private void SiguienteFrase()
    {
        Debug.Log("Pasamos a la siguiente frase!");
    }
    private void CompletarFrase()
    {

    }

    private void TerminarDialogo()
    {

    }



}
