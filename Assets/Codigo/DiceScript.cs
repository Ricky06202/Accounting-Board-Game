using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadoScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 VelocidadDado;

    // Para inicializar
    void Start(){
        rb=GetComponent<Rigidbody>();
    }
    //Update es llamado un vez por frame
    void Update(){
        VelocidadDado=rb.velocity;
        if (Input.GetKeyDown(KeyCode.Space)){
            DadonumeroTextScript.numeroDado= 0;
            float dirX=Random.Range (0,500);
            float dirY=Random.Range (0,500);
            float dirZ=Random.Range (0,500);
            transform.position=new Vector3 (0,2,0);
            transform.rotation=Quaternion.identity;
            rb.AddForce(transform.up*500);
            rb.AddTorque(dirX,dirY,dirZ);
        }
    }

}
