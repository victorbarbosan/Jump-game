using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    // Variables
    int coinsCount = 0;
    [SerializeField] Text coinsCountText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinsCount++;
            coinsCountText.text = "Coins: " + coinsCount.ToString();
        }
    }
}
