using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DadoSimboloTextScript : MonoBehaviour
{
    Text text;
    public static int simboloDado;

    // Para inicializar
    void Start (){
        text=GetComponent<Text> ();
    }
    
    void Update (){
        text.text = simboloDado.ToString ();
    }
}
