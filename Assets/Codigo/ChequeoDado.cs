using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChequeoDado : MonoBehaviour
{
    Vector3 velocidadDado;
    
    void OnTriggerStay(Collider colicion){
        GameObject padre = colicion.gameObject.transform.parent.gameObject;
        if (padre.GetComponent<Rigidbody>().velocity.Equals(Vector3.zero)){
            string nombre = colicion.gameObject.name;
            string textoLado = nombre.Substring("Lado".Length);
            if (padre.name == "Dado Numerico")
                DadoTexto.textoNumeroDado = textoLado;
            else
                DadoTexto.textoSimboloDado = textoLado;
        }
    }

}
