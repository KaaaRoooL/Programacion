using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unidades
{

    protected int vidaTotal;
    protected int vidaActual;
    private Vector3 dimension;

    private int vision;

    protected bool viva;

   

    public string serAtacado(int poderAtaque){
        vidaActual= vidaActual - poderAtaque;
         if(vidaActual <= 0){
            morir();
         }
        return "Fui atacado con " + poderAtaque + " puntos";
    }


    public string nacer(){
        viva = true;
        Debug.Log("Nací!");
        return "Nací";
    }

    public string morir(){
        viva = false;
        Debug.Log("Morí!");
        return "Morí";            
    }

    public bool getViva(){
        return viva;
    }
}
