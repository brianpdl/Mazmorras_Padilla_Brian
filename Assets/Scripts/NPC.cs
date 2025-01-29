using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Outline outline;

    [SerializeField] private EventManagerSO eventManager;

    [SerializeField] private MisionSO misionAsociada;

    [SerializeField] private DialogoSO dialogo1;

    [SerializeField] private DialogoSO dialogo2;

    [SerializeField] private Transform puntoCamara;

    [SerializeField] private float lookAtDuration;

    [SerializeField] private float tiempoRotacion;

    [SerializeField] private DialogoSO dialogoActual;

    // Start is called before the first frame update

    private void Awake()
    {
        dialogoActual = dialogo1;


    }

    private void OnEnable()
    {
        eventManager.onTerminarMision += CambiarDialogo;
    }

    private void CambiarDialogo(MisionSO obj)
    {
        //transform.DOLookAt(interactuador.position, lookAtDuration, AxisConstraint.Y) OnComplete(IniciarDialogo);
    }
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
        
        //SStransform.DOLookAt(interactuador.position, tiempoRotacion, AxisConstraint.Y).OnComplete(() => SistemaDialogos.sD.IniciarDialogo
    }

    


}
