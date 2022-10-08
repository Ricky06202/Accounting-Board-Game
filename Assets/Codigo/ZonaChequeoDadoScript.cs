using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaChequeoDadoScript : MonoBehaviour
{
    Vector3 VelocidadDado;

    //Update es llamado una vez por frame
    void FixedUpdate(){
        VelocidadDado = DadoScript.VelocidadDado;
    }
    
    void OnTriggerStay(Collider col){
        if (VelocidadDado.x == 0f && VelocidadDado.y == 0f && VelocidadDado.z== 0f){
            switch(col.gameObject.name){
                case "Side1":
                   DadonumeroTextScript.numeroDado=6;
                   break;
                case "Side2":
                   DadonumeroTextScript.numeroDado=5;
                   break;
                case "Side3":
                    DadonumeroTextScript.numeroDado=4;
                   break;
                case "Side4": 
                    DadonumeroTextScript.numeroDado=3;
                   break;               
                case "Side5":
                   DadonumeroTextScript.numeroDado=2;
                   break;
                case "Side6":
                    DadonumeroTextScript.numeroDado=1;
                   break;
            }
        }
    }

}
