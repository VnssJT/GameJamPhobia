using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursosJugador : MonoBehaviour
{
    //Valor de los contadores durante la partida
    public float vida_actual;
    public float hambre_actual;
    public float ansiedad_actual;
    public float pilaLinterna_actual;

    //Valor máximo de los contadores
    private float hambre_max = 100f;
    private float vida_max = 100f;
    private float ansiedad_max = 100f;
    private float pilaLinterna_max = 100f;

    //Intervalos de tiempo en los que cada contador resta valor
    private int intervalo_hambre = 3;
    private int intervalo_ansiedad = 3;
    private int intervalo_pilaLinterna = 3;

    //Contador de tiempo
    private float contadorTiempo;
    private int contadorSegundos;

    // Start is called before the first frame update
    void Start()
    {
        vida_actual = vida_max;
        hambre_actual = hambre_max;
        ansiedad_actual = ansiedad_max;

        contadorTiempo = 0f;
        contadorSegundos = 0;

    }

    // Update is called once per frame
    void Update()
    {
        contadorTiempo += Time.deltaTime;
        if(contadorTiempo > 1f) contarSegundos();
        //contadorSegundos = (int)contadorTiempo;
        //Debug.Log(contadorSegundos);
        //if(contadorSegundos % intervalo_hambre == 0)  DescontarHambre(2f);
    }

    void contarSegundos()
    {
        contadorSegundos++;
        contadorTiempo = 0f;
        //Debug.Log(contadorSegundos);

        if(contadorSegundos % intervalo_hambre == 0)  DescontarHambre(2f);
    }

    void DescontarHambre(float intro)
    {
        hambre_actual -= intro;
        if(hambre_actual > 0f)  Debug.Log("Te quedan "+ hambre_actual +" puntos de hambre");
        else                    Debug.Log("Has muerto de hambre");
    }
}
