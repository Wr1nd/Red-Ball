using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    int collected = 0;
    public TextMeshProUGUI coinText;
    public int coinsToCollect;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collected++;
            coinText.text = collected.ToString() + "/" + coinsToCollect.ToString();
            
            Destroy(gameObject);
        }
    }

}
