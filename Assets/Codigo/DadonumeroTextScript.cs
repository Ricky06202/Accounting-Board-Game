﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DadonumeroTextScript : MonoBehaviour
{
    Text text;
    public static int LetraDado;

    // Para inicializar
    void Start (){
        text=GetComponent<Text> ();
    }
    
    void Update (){
        text.text = LetraDado.ToString ();
    }
}
