using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using Ebac.Core.Singleton;


public class ItemManager : Singleton<ItemManager>
{
    public SOInt coins;
    public SOInt gems;
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextGems;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        gems.value = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        UpdateUI();
    }

    public void AddGemsG(int amount = 1)
    {
        gems.value += amount;
        UpdateUI();
    }

    public void AddGemsP(int amount = 5)
    {
        gems.value += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        //uiTextCoins.text = coins.ToString();
        //UIInGameManager.UpdateTextCoins(coins.value.ToString());
    }
}
