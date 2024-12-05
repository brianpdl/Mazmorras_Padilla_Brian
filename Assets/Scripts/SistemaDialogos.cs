using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDialogos : MonoBehaviour
{
    [SerializeField] private GameObject marcos;
    //[SerializeField] private TMP_Text textoDialogo; a�adir el tmp texto
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
    private void EscribirFrase()
    {

    }

    private void SiguienteFrase()
    {

    }

    private void TerminarDialogo()
    {

    }
}
