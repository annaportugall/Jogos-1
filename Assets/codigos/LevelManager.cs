using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public int totalCoins;
    public CoinCollector coinCollector;
    public GameObject levelCompleteUI; // arraste o LevelCompleteText aqui

    void Awake()
    {
        instance = this;
        if (levelCompleteUI != null)
            levelCompleteUI.SetActive(false); // começa invisível
    }

    void Start()
    {
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        Debug.Log("Total de moedas no nível: " + totalCoins);

        if (coinCollector == null)
        {
            coinCollector = GameObject.FindGameObjectWithTag("Player").GetComponent<CoinCollector>();
        }
    }

    public void CheckLevelCompletion()
    {
        Debug.Log($"Coins coletadas: {coinCollector.coinCount}/{totalCoins}");
        if (coinCollector.coinCount >= totalCoins)
        {
            LevelCompleted();
        }
    }

    void LevelCompleted()
    {
        Debug.Log("⭐ Nível completo! ⭐");
        if (levelCompleteUI != null)
            levelCompleteUI.SetActive(true);
    }
}
