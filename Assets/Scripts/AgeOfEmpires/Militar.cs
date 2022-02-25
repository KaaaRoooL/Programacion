using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Militar : Persona
{
    
    private int poderAtaque;
    private int rangoAtaque;
    
    public Militar(string n, int poder){
        nacer();
        velocidadMov = 40;
        poderAtaque = 50;
        nombre=n;
        vidaTotal=500;
        vidaActual = vidaTotal;
        Debug.Log("Creado militar" + nombre);
    }
    
    

    public int atacar(){   
        if(!viva){
            return 0;
        }  
        Debug.Log(nombre + " atacó con " + poderAtaque); 
        return poderAtaque;
    }



    public override string ToString()
    {
        return "Militar. Nome: "+nombre+", velocidad movimiento: "+velocidadMov+",vida Actual "+ vidaActual+" ,poder Ataque "+poderAtaque;
    }



  
}
