using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public GameObject Coin;
    public List<Coin> CoinsList = new List<Coin>();
    public Text CoinsText;


    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<40; i++)
        {
            Quaternion CoinRotation = Quaternion.Euler(-90, 0, 0);
            GameObject NewCoin = Instantiate(Coin, new Vector3(Random.Range(-40f, 40f), 1.66f, Random.Range(-40f, 40f)), CoinRotation);
            CoinsList.Add(NewCoin.GetComponent<Coin>());
        }
        CoinsText.text = "Осталось: " + CoinsList.Count.ToString() + " монет";
    }

    public void CoinCollect (Coin coin)
    {
        CoinsList.Remove(coin);
        Destroy(coin.gameObject);
        CoinsText.text = "Осталось: " + CoinsList.Count.ToString() + " монет";
    }
    public Coin GetClosest(Vector3 point)
    {
        float minDistance = Mathf.Infinity;
        Coin closestCoin = null;
        for (int i = 0; i < CoinsList.Count; i++)
        {
            float distance = Vector3.Distance(point, CoinsList[i].transform.position);
            if(distance < minDistance)
            {
                minDistance = distance;
                closestCoin = CoinsList[i];
            }
        }
        return closestCoin;
    }


}
