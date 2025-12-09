using UnityEngine;

public class ScriptMoeda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger!");

            // Tenta pegar o CoinCollector no jogador
            CoinCollector coinCollector = other.GetComponent<CoinCollector>();

            if (coinCollector != null)
            {
                coinCollector.CollectCoin(); // adiciona moeda
            }
            else
            {
                Debug.LogWarning("O player não tem CoinCollector!");
            }

            Destroy(gameObject); // destrói a moeda
        }
    }
}
