using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string CodigoHelado;
    public int CantidadDeHelado;

    float CostoHelado;

    // Start is called before the first frame update
    void Start()
    {
        if (CantidadDeHelado < 250 || CantidadDeHelado > 3000)
        {
            Debug.Log("Cantidad de helado no valida");
            return;
        }
        if (CodigoHelado !="CHO" && CodigoHelado != "DLL" && CodigoHelado != "FRU")
        {
            Debug.Log("Codigo no valido");
            return;

        }

        CostoHelado = CantidadDeHelado * (500 / 1000.0f);

        if (CodigoHelado == "FRU")
        {
            CostoHelado = CostoHelado * 0.1f;
        }

        Debug.Log("Debe abonar " + CostoHelado);
    }

    // Update is called once per frame
    void Update()
    {

    }
}