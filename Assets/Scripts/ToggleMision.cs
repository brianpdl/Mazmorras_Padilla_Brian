using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ToggleMision : MonoBehaviour
{

    [SerializeField]
    private TMP_Text textoMision; //recipiente donde meter los textos de cada mision
    private Toggle toggle;

    public TMP_Text TextoMision { get => textoMision;}
    public Toggle Toggle { get => toggle;}
}
