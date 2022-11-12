using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DadoTexto : MonoBehaviour
{
    Text texto;
    public GameObject dadoNumero, dadoSimbolo;
    public static string textoNumeroDado, textoSimboloDado;

    // Para inicializar
    void Start (){
        texto=GetComponent<Text> ();
    }
    
    void Update (){
        if(dadoNumero.GetComponent<CodigoDado>().sePuedenTirar)
            textoNumeroDado = "0";
        if(dadoSimbolo.GetComponent<CodigoDado>().sePuedenTirar)
            textoSimboloDado = "0";
        texto.text = textoNumeroDado + "      " + textoSimboloDado;
    }
}
