using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodigoDado : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 velocidadDado, posicion;
    private Quaternion rotacion;
    public bool sePuedenTirar = true;
    public GameObject suelo;

    // Para inicializar
    void Start(){
        rb=GetComponent<Rigidbody>();
        transform.position = new Vector3(transform.position.x ,suelo.transform.position.y + Vector3.up.y, transform.position.z);
        transform.rotation = Quaternion.identity * new Quaternion(0,-1,0,0);
        posicion = transform.position;
        rotacion = transform.rotation;
    }
    //Update es llamado un vez por frame
    void Update(){
        velocidadDado = rb.velocity;
        if (Input.GetKeyDown(KeyCode.Space) && velocidadDado.Equals(Vector3.zero) && sePuedenTirar){
            sePuedenTirar = false;
            DadoTexto.textoSimboloDado = DadoTexto.textoNumeroDado = "0";
            float dirX=Random.Range (0,500);
            float dirY=Random.Range (0,500);
            float dirZ=Random.Range (0,500);
            transform.position= posicion;
            transform.rotation=Quaternion.identity;
            rb.AddForce(transform.up*700);
            rb.AddTorque(dirX,dirY,dirZ);
        }
    }

}
