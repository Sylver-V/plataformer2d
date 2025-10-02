using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI coinsText;

    private void Start()
    {
        // Inscreve no evento de mudança de moedas
        ItemManager.Instance.OnCoinsChanged += UpdateCoinsDisplay;
    }

    private void OnDestroy()
    {
        // Remove inscrição para evitar erros
        ItemManager.Instance.OnCoinsChanged -= UpdateCoinsDisplay;
    }

    private void UpdateCoinsDisplay(int newCoinAmount)
    {
        coinsText.text = newCoinAmount.ToString();
    }
}
