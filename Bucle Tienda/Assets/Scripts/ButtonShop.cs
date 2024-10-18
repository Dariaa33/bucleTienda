using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonShop : MonoBehaviour
{
    
    [SerializeField]
    Wallet myWallet;

    [SerializeField]
    TextMeshProUGUI textButton;
    [SerializeField]
    string[] posiblesNombres;
    [SerializeField]
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;

    void Start()
    {
        nameItem = posiblesNombres[Random.Range(0, posiblesNombres.Length)];
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(25f, 350f);
        textButton.text = nameItem + priceItem.ToString() + " €";
    }

    public void ClickEnButtonDeTienda()
    {
        myWallet.InformarCompra(nameItem, priceItem);
    }
    
    
}
