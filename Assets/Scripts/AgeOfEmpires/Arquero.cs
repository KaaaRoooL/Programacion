using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arquero : Militar
{
    public Arquero(string n){
        nacer();
        velocidadMov = 70;
        rangoAtaque = 20;
        poderAtaque = 5;
        nombre=n;
        vidaTotal=250;
        vidaActual = vidaTotal;
        Debug.Log("Creado arquero" + nombre);
    }
}
