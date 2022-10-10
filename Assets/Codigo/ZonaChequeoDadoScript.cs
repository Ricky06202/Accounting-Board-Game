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
                   DadonumeroTextScript.numeroDado= R+;
                   break;
                case "Side2":
                   DadonumeroTextScript.numeroDado= P.N;
                   break;
                case "Side3":
                    DadonumeroTextScript.numeroDado=P;
                   break;
                case "Side4": 
                    DadonumeroTextScript.numeroDado=A;
                   break;               
                case "Side5":
                   DadonumeroTextScript.numeroDado=R-;
                   break;
                case "Side6":
                    DadonumeroTextScript.numeroDado=#;
                   break;
            }
        }
    }

}
