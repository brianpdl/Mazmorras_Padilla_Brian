using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Event manager")]

public class EventManagerSO : ScriptableObject
{
    public event Action<MisionSO> onNuevaMision;
    public event Action<MisionSO> onActualizarMision;
    public event Action<MisionSO> onTerminarMision;//esto es el evento.


    public void NuevaMision(MisionSO mision)
    {
        // lanzo la notificacion (EVENTO) por si alguien le interresa.
        onNuevaMision?.Invoke(mision);
    }
    public void ActualizarMision(MisionSO mision)
    {
        onActualizarMision?.Invoke(mision);
    }

    public void TerminarMision (MisionSO mision)
    {
        onTerminarMision?.Invoke(mision);
    }
}
