using UnityEngine;

public class ScriptMoeda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinCollector coinCollector = other.GetComponent<CoinCollector>();
            if (coinCollector != null)
                coinCollector.CollectCoin();

            Destroy(gameObject); // destrói a moeda
        }
    }
}
