using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Persona : PC
{
    
    protected int velocidadMov;

    protected string nombre;

    //List<string> nombre = new List<string>();
    
    
  

    public string movimientoTierra(){
        Debug.Log("Me muevo a " + velocidadMov);
        return "Me muevo a " + velocidadMov;
    }



    

}
