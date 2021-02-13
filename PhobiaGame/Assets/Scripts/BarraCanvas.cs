using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraCanvas : MonoBehaviour
{
    public Slider slider;

    public void Inicializar(float maximo, float actual)
    {
        slider.maxValue = maximo;
        slider.value = actual;
    }

    public void SetValor(float actual)
    {
        slider.value = actual;
    }
}
