using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshProUGUI labelSaldo;
    [SerializeField]
    TextMeshProUGUI labelConfirmación;
    [SerializeField]
    GameObject confirmarCompra;
    [SerializeField]
    GameObject noSaldo;

    float precioObjetoQueCompro;
    
    // Start is called before the first frame update
    void Start()
    {
        saldo = Random.Range(450f, 950f);
        labelSaldo.text = saldo.ToString("000.000") + " €";
    }

    
    public void InformarCompra(string nameItem, float precio)
    {
        if (saldo > precio)

        {
            labelConfirmación.text = "¿Quieres comprar " + nameItem + " por" + precio + " €";
            confirmarCompra.SetActive(true);
            precioObjetoQueCompro = precio;
            /*saldo -= precio;
            labelSaldo.text = saldo.ToString("000.000") + " eur";*/

        }
        else
        {
            noSaldo.SetActive(true);
        }
    }

    void Update()
    {
        
    }

    public void ConfirmarCompra()
    {
        if (saldo > precioObjetoQueCompro)
        {
            saldo = saldo - precioObjetoQueCompro;
            precioObjetoQueCompro = 0.0f;
            labelSaldo.text = saldo.ToString("000.00") + " €";
            confirmarCompra.SetActive(false);

        }
        else
        {
            confirmarCompra.SetActive(false);
            noSaldo.SetActive(true);
        }
    }
}
