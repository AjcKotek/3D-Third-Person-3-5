using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private PlayerInventory playerInventory;
    private TextMeshProUGUI coinText;

    void Start()
    {
       coinText = GetComponent<TextMeshProUGUI>(); 
    }

    public void UpdateCoinText()
    {
        coinText.text = playerInventory.NumberOfCoins.ToString();
    }
}
