using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public int coinCount = 0;
    public TextMeshProUGUI coinText; // arraste o texto do Canvas no Inspector

    void Start()
    {
        UpdateUI();
    }

    public void CollectCoin()
    {
        coinCount++;           // aumenta contador
        UpdateUI();            // atualiza UI
        LevelManager.instance.CheckLevelCompletion();  // verifica se terminou o nível
    }

    void UpdateUI()
    {
        coinText.text = coinCount.ToString();
    }
}
