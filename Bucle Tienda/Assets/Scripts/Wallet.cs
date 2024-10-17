using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshPro labelSaldo;

    [SerializeField]
    GameObject confirmarCompra;
    [SerializeField]
    GameObject noSaldo;
    
    // Start is called before the first frame update
    void Start()
    {
        saldo = Random.Range(450f, 950f);
        labelSaldo.text = saldo.ToString("000.000") + " €";
    }

    
    public void RestartSaldo(float precio)
    {
        if (saldo > precio)

        {
            saldo -= precio;
            labelSaldo.text = saldo.ToString("000.000") + " €";
        }
        else
        {
            noSaldo.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
