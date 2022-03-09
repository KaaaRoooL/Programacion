using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificios : PC
{
    
  private tipoEdificio tipo;
    
    
  
  public Edificios() {
        nacer();
        vidaTotal=500;
        vidaActual = vidaTotal;
        Debug.Log("Creado Edificio");
    }






  enum tipoEdificio{
        Casa,
        Granja,
        Cuartel,
        Iglesia,
        Castillo
    }




}