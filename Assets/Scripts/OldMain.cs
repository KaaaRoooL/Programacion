using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMain : MonoBehaviour
{


    
    // Start is called before the first frame update
    void Start()
    {
        //Crea unha clase nova chamada triángulo, que teña un atributo lado, un método calcular area
        //e instancia duas desas clases no main, imprimindo por pantalla a área
        


        //Triangulo tri1 = new Triangulo(1.5f);
        //float area = tri1.calcularArea();
        //Debug.Log("Área Triángulo 1 "+ area);


        //Triangulo tri2 = new Triangulo(5.36f);
        //float area2 = tri2.calcularArea();
       // Debug.Log("Área Triángulo 2 "+ area2);


        //Crea método calcularAreaStatic e chamao
       // Debug.Log(Triangulo.calcularAreaStatic(2.5f));
        
        //Creamos variable estática que se suma cando facemos unha nova instancia
        //Debug.Log(Triangulo.mostrarCantidade());



        //Crear mil triangulos de lado aleatorio, gardando triangulos nun array
        //float [] areas= new float[5];
        
        //List<float> areasList = new List<float>();
        //for(int i=0; i < areas.Length; i++){

        //    areas[i] = Triangulo.calcularAreaStatic(0.7f + 2*i);
           
        //    areasList.Add(Triangulo.calcularAreaStatic(Random.Range(0,99)));
           
        //   areas[i] = Triangulo.calcularAreaStatic(Random.Range(0,99));
        //}  
        //Debug.Log(areas[2]);
       // Debug.Log(areas[4]);

       // Debug.Log(areasList[2]);
       // Debug.Log(areasList[4]);

        
       
        
        //Crea unha lista de 5 triangulos e imprime a súa área
        List<Triangulo> triangulos = new List<Triangulo>();
     
        
        for(int i=0; i < 5; i++){
                triangulos.Add(new Triangulo(Random.Range(0,99)));



        }
       
          for(int i=0; i < triangulos.Count; i++){       
                 Debug.Log(Triangulo.calcularAreaStatic(Random.Range(0,99)));

          }
        
       
        
        
        

    }
   

}

    


