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
        /*List<Aldeano> aldeanoRojo = new List<Aldeano>();
        List<Militar> militaresRojos = new List<Militar>();

        aldeanoRojo.Add(new Aldeano("AldeanoRojo"));
        militaresRojos.Add(new Militar("MilitarRojo1", 10));
        militaresRojos.Add(new Militar("MilitarRojo2", 20));
        militaresRojos.Add(new Militar("MilitarRojo3", 30));


        //Equipo Azul
        List<Aldeano> aldeanoAzul = new List<Aldeano>();
        List<Militar> militaresAzules = new List<Militar>();

        aldeanoAzul.Add(new Aldeano("AldeanoAzul"));
        militaresAzules.Add(new Militar("MilitarAzul1", 10));
        militaresAzules.Add(new Militar("MilitarAzul2", 20));
        militaresAzules.Add(new Militar("MilitarAzul3", 30));
        */

        //for(int i=0; i<3; i++){
        //    militaresAzules.Add(new Militar(Persona.ListaNomes[Random.Range(0,Persona.ListaNomes.Count)], (i+1) * 10;
        //}

        
        

        
        /*for(int i =0; i<10; i++){
            
            aldeanoRojo[0].serAtacado(militaresAzules[Random.Range(0, 3)].atacar());
            aldeanoAzul[0].serAtacado(militaresRojos[Random.Range(0, 3)].atacar());
        
            if (!aldeanoRojo[0].getViva()){
                aldeanoRojo[0] = null;
                Debug.Log("Destruimos aldeano Rojo");
                break;
            }

            if (!aldeanoAzul[0].getViva()){
                aldeanoAzul[0] = null;
                Debug.Log("Destruimos aldeano Azul");
                break; 
            }
        }

        */


       /* int aleatorio= Random.Range(0,2);
         if(aleatorio ==0){
            aldeanoRojo[0].serAtacado(militaresAzules[Random.Range(0, 3)].atacar());
        }

         while (aldeanoRojo[0].getViva() && aldeanoAzul[0].getViva()){
                aldeanoRojo[0].serAtacado(militaresAzules[Random.Range(0, 3)].atacar());
                if (!aldeanoRojo[0].getViva()){
                    Debug.Log("Ganó el Azul");
                    break;
                }
                aldeanoAzul[0].serAtacado(militaresRojos[Random.Range(0, 3)].atacar());
                if (!aldeanoAzul[0].getViva()){
                    Debug.Log("Ganó el Rojo");
                    break;

            }

         }*/


       /* int opcion= Random.Range(0,2);
        while (aldeanoRojo[0].getViva() && aldeanoAzul[0].getViva()){
            
            if(opcion == 1){
                aldeanoRojo[0].serAtacado(militaresAzules[Random.Range(0, 3)].atacar());
                if (!aldeanoRojo[0].getViva()){
                    Debug.Log("Ganó el Azul");
                    break;
                }
                aldeanoAzul[0].serAtacado(militaresRojos[Random.Range(0, 3)].atacar());
                if (!aldeanoAzul[0].getViva()){
                    Debug.Log("Ganó el Rojo");
                    break;
                }
            } else {
                aldeanoAzul[0].serAtacado(militaresRojos[Random.Range(0, 3)].atacar());
                if (!aldeanoAzul[0].getViva()){
                    Debug.Log("Ganó el Rojo");
                    break;
            }
               aldeanoRojo[0].serAtacado(militaresAzules[Random.Range(0, 3)].atacar());
                if (!aldeanoRojo[0].getViva()){
                    Debug.Log("Ganó el Azul");
                    break;
                }
                
            }
                
        
        }  */       




        /*int aleatorio= Random.Range(0,2);
        if(aleatorio ==0){
            MilitarAtacaAldeano((militaresAzules[Random.Range(0, 3)]),aldeanoRojo[0]);
            }

        while (aldeanoRojo[0].getViva() && aldeanoAzul[0].getViva()){
               
                if (! MilitarAtacaAldeano((militaresAzules[Random.Range(0, 3)]),aldeanoRojo[0])){
                    Debug.Log("Ganó el Azul");
                    break;
                }
                
                if (! MilitarAtacaAldeano((militaresRojos[Random.Range(0, 3)]),aldeanoAzul[0])){
                    Debug.Log("Ganó el Rojo");
                    break;

            }

         }*/


        
        /*
        int atacante = Random.Range(0,2);
        int defensor;
        List<List<Aldeano>> aldeanos = new List<List<Aldeano>>();
        aldeanos.Add(aldeanoAzul);
        aldeanos.Add(aldeanoRojo);

        List<List<Militar>> militares = new List<List<Militar>>();
        militares.Add(militaresAzules);
        militares.Add(militaresRojos);

        if(atacante == 0){
            defensor = 1;

        } else {
            defensor = 0;
        }

          while (aldeanoRojo[0].getViva() && aldeanoAzul[0].getViva()){
               
                if (! MilitarAtacaAldeano((militares[atacante][Random.Range(0, 3)]),aldeanos[defensor][0])){
                    Debug.Log("Ganó alguien");
                    break;
                }

                atacante = defensor;
                    if(atacante == 0){
                        defensor = 1;

                    } else {
                        defensor = 0;
                    }

                    }
        */
                
               
        /* Exercicio final: Crea duas listas, un do equipo vermello, e un do equipo azul. OK
            As duas listas conterán todas as unidades de cada equipo. OK
            Crea as clases guerreiro e arqueiro. OK
            Crea dous aldeanos para cada equipo. Crea un edificio para cada equipo. OK
            Crea un guerreiro e un arqueiro por equipo. O guerreiro ataca 10 e o arqueiro 5. OK
            Fai que un dos dous aleatoriamente, ataque a unha das catro unidades aleatoriamente (asumimos que están en rango de ataque) OK
            Se unha unidade xa morreu, debe notificarse, pero se atacan, pasase o turno.
            En cada unidade de tempo, atacará un dos dous equipos aleatoriamente
            Imprime por pantalla, o que pasa e quen gaña.

        */

        List <Unidades> unidadRoja = new List<Unidades>();
        unidadRoja.Add(new Aldeano("AldeanoRojo1"));
        unidadRoja.Add(new Aldeano("AldeanoRojo2"));
        unidadRoja.Add(new Edificios());
        unidadRoja.Add(new Guerrero("GuerreroRojo"));
        unidadRoja.Add(new Arquero("ArqueroRojo"));

        List<Unidades> unidadAzul = new List<Unidades>();
        unidadAzul.Add(new Aldeano("AldeanoAzul1"));
        unidadAzul.Add(new Aldeano("AldeanoAzul2"));
        unidadAzul.Add(new Edificios());
        unidadAzul.Add(new Guerrero("GuerreroAzul"));
        unidadAzul.Add(new Arquero("ArqueroAzul"));
        

        
        unidadRoja[Random.Range(0, 5)].serAtacado(((Militar)unidadAzul[Random.Range(3, 5)]).atacar());

        unidadAzul[Random.Range(0, 5)].serAtacado(((Militar)unidadRoja[Random.Range(3, 5)]).atacar());
        
    }

    /*
        private bool MilitarAtacaAldeano(Militar m, Aldeano a){
                a.serAtacado(m.atacar());
                //return a.getViva();
                if (! a.getViva()){
                    return false;
            } else {
                    return true;
            }
            
    
        }

        */
}




    

