using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalCoins : MonoBehaviour
{
    public GameObject CoinDisplay;
    public static int CoinCount;
    public int InternalCoin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InternalCoin = CoinCount;
        CoinDisplay.GetComponent<Text>().text = "金币: " + CoinCount;

    }
}
