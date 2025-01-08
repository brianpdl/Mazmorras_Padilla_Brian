using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SistemaCombate combate;
    private SistemaPatrulla Patrulla;

    private Transform mainTarget;

    public SistemaCombate Combate { get => combate; set => combate = value; }
    public SistemaPatrulla Patrulla1 { get => Patrulla; set => Patrulla = value; }
    public Transform MainTarget { get => mainTarget; set => mainTarget = value; }

    private void Start()
    {
        Patrulla.enabled = false;
    }
    public void ActivaCombate(Transform transform)
    {
        mainTarget = target;
        combate.enabled = true;
    }

    
  
}
