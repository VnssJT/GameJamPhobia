using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLinterna : MonoBehaviour
{
    
    Light luzLinterna;

    void Start()
    {
        luzLinterna = GetComponentInChildren<Light>();
    }

    
    public void EncenderLinterna()
    {
        luzLinterna.enabled = true;
    }

    public void ApagarLinterna()
    {
        luzLinterna.enabled = false;
    }

    public void interruptorLinterna()
    {
        if(luzLinterna.enabled) ApagarLinterna();
        else                    EncenderLinterna();
    }
}
