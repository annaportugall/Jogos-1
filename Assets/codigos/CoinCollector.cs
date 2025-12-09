using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public int coinCount = 0;
    public TextMeshProUGUI coinText; // <-- CAMPO QUE VAI APARECER NO INSPECTOR

    public void CollectCoin()
    {
        coinCount++;
        UpdateUI();
    }

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        coinText.text = coinCount.ToString();
    }
}
