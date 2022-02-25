using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : Civil
{
   
   public Aldeano(string n){
        nacer();
        velocidadMov = 50;
        nombre = n;
        vidaTotal=100;
        vidaActual = vidaTotal;
        Debug.Log("Creado aldeano" +nombre);
   }

    public string trabajar(){
        if(!viva){
            return "No puedo, estoy muerto";
        }
        Debug.Log("Trabajando");
        return "Trabajando";
    }


    public override string ToString()
    {
        return "Aldeano. Nome: "+nombre+", velocidad movimiento: "+velocidadMov+",vida Actual "+ vidaActual;
    }

    

}
