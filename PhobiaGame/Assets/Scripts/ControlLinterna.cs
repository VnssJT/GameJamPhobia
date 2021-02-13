using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLinterna : MonoBehaviour
{
    
    Light luzLinterna;
    public bool encendida;

    void Start()
    {
        luzLinterna = GetComponentInChildren<Light>();
        Encender();
    }

    
    public void Encender()
    {
        encendida = true;
        luzLinterna.enabled = true;
    }

    public void Apagar()
    {
        encendida = false;
        luzLinterna.enabled = false;
    }

    public void interruptor()
    {
        if(luzLinterna.enabled) Apagar();
        else                    Encender();
    }
}
