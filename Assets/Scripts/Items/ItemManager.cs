using UnityEngine;
using Ebac.Core.Singleton;
using System;

public class ItemManager : Singleton<ItemManager>
{
    public int coins;

    // Evento para notificar quando moedas mudam
    public Action<int> OnCoinsChanged;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins = 0;
        OnCoinsChanged?.Invoke(coins); // Atualiza HUD no início
    }

    public void AddCoins(int amount = 1)
    {
        coins += amount;
        OnCoinsChanged?.Invoke(coins); // Notifica HUD
    }
}
