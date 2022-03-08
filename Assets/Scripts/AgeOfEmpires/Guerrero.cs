using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : Militar
{
    
    public Guerrero(string n){
        nacer();
        velocidadMov = 40;
        poderAtaque = 10;
        nombre=n;
        vidaTotal=500;
        vidaActual = vidaTotal;
        Debug.Log("Creado guerrero" + nombre);
    }
}
