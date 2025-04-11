using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string GustoElegido;
    public int cantidadElegida;
    int descuentoPromocion = 10;
    float precioXg = 1.25f;
    float precioTotal;
    


    // Start is called before the first frame update
    void Start()
    {
        
        if(cantidadElegida < 250 || cantidadElegida > 3000)
        {
            Debug.Log("cantidad elegida no disponible, elegir un valor entre 250 y 300");
                return; 
        }
        if(GustoElegido == "fru" || GustoElegido == "FRU"){
            precioTotal = (cantidadElegida * precioXg) - (cantidadElegida * precioXg/descuentoPromocion);        
            Debug.Log("el precio para esa cantidad de helado del gusto frutilla es: " + precioTotal);
        }
        else if (GustoElegido == "cho" || GustoElegido == "CHO")
        {
            precioTotal = cantidadElegida * precioXg;
            Debug.Log("el precio para esa cantidad de helado del gusto chocolate es: " + precioTotal);
        }
        else if (GustoElegido == "ddl" || GustoElegido == "DDL")
        {
            precioTotal = cantidadElegida * precioXg;
            Debug.Log("el precio para esa cantidad de helado del gusto dulce de leche es: " + precioTotal);
        }
        else {
            Debug.Log("codigo de helado elegido mal elegido, porfavor probar otra vez");
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
