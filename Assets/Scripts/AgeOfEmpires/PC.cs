using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PC : Unidades
{

    private int coste;

    private List<Superficie> superficiePosible;


    enum Superficie{
        Tierra,
        Mar,
        Montanha,
        Bosque
    }
}
