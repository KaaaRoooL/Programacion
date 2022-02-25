using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Crea unha clase nova chamada triángulo, que teña un atributo lado, un método calcular area
    //e instancia duas desas clases no main, imprimindo por pantalla a área
public class Triangulo
{
   private float lado;
   private static int cantidadeTriangulos = 0;
    

   public Triangulo(float l) {

       lado = l;

       cantidadeTriangulos++;

   }


   public float calcularArea(){
        return lado * lado/2;


   }

   //metodo calcularAreaStatic 
   //Estático siempre es de la CLASE, no hace falta instancia

   public static float calcularAreaStatic(float unLado){
        return unLado * unLado/2;

   }

   public static int mostrarCantidade(){
        return cantidadeTriangulos;
   }

}
