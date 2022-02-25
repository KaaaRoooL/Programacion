using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        

        //Aldeano aldeano = new Aldeano();
        

        //aldeano.trabajar();
        //aldeano.movimientoTierra();



        
        
        //List<Aldeano> listAldeanos = new List<Aldeano>();

        //for(int i = 0; i < 10; i ++){
       //     Aldeano temporal = new Aldeano();
       //     temporal.trabajar();
      //      listAldeanos.Add(temporal);
       // }

      //  foreach (Aldeano temporal in listAldeanos){
       //     temporal.trabajar();
      //  }



/*
        //Crea un aldeano
        Aldeano victima = new Aldeano("Eustaquio");
       
        //Crea un militar
        Militar verdugo = new Militar ("Adolfo");
        

        Debug.Log(victima.ToString());

        Debug.Log(verdugo.ToString());

        for(int i = 0 ; i<11; i++){
            victima.serAtacado(verdugo.atacar());
            Debug.Log(victima.ToString());
            //Creas las funciones de vivir y morir y destruye el objecto si no está vivo
            if (!victima.getViva()){
                victima=null;
                Debug.Log("Destruimos victima");
                break;
            }
        }

        //Fai que o militar ataque o aldeano
        

        
        //Crea un método ToString() para Aldeano e para Militar que devolva un string con todos os atributos do obxecto
        Debug.Log(victima.ToString());
        */

        //Hay dos equipos rojo y azul cada equipo tiene 1 aldeano que recibirá los ataques y 3 militares, el primer militar ataca 10, el segundo 20 y el tercero 30
        //comienzan atacando lo rojos, luego los azules y asi sucesivamente, en cada ataque selecciona aleatoriamente cual de los tres militares ataca
        //gana el primer equipo que consiga matar el aldeano del otro equipo

        

       
        //Equipo Rojo
        List<Aldeano> aldeanoRojo = new List<Aldeano>();
        List<Militar> militaresRojos = new List<Militar>();

        aldeanoRojo.Add(new Aldeano("AldeanoRojo"));
        militaresRojos.Add(new Militar("MilitarRojo1", 10));
        militaresRojos.Add(new Militar("MilitarRojo2", 20));
        militaresRojos.Add(new Militar("MilitarRojo3", 30));


        //Equipo Azul
        List<Aldeano> aldeanoAzul = new List<Aldeano>();
        List<Militar> militaresAzules = new List<Militar>();

        aldeanoAzul.Add(new Aldeano("AldeanoAzul"));
        militaresAzules.Add(new Militar("MilitarAzul1",10));
        militaresAzules.Add(new Militar("MilitarAzul2", 20));
        militaresAzules.Add(new Militar("MilitarAzul3", 30));

        
        

        

        aldeanoRojo[0].serAtacado(militaresAzules[Random.Range(0, 3)].atacar());
        aldeanoAzul[0].serAtacado(militaresRojos[Random.Range(0, 3)].atacar());
        
        



        
        
        

        

        

        
       



        
        
        
        
        
        
        



        
        
    }

    
}
