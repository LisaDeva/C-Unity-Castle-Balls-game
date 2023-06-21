using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public CoinManager CoinManager;
    public Coin ClosestCoin;

    private void Update()
    {
        ClosestCoin = CoinManager.GetClosest(transform.position);
        Vector3 ToTarget = ClosestCoin.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(ToTarget);
    }

}
