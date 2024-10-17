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
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;

    void Start()
    {
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(25f, 350f);
        textButton.text = priceItem.ToString() + " eur";
    }

    public void ClickEnButtonDeTienda()
    {
        myWallet.RestartSaldo(priceItem);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
