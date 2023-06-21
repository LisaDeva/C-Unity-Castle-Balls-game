using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{
    public CoinManager CoinManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            CoinManager.CoinCollect(other.GetComponent<Coin>());
        }
    }
}
