using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUP : MonoBehaviour
{

    public AudioSource CoinAudio;

    void OnTriggerEnter(Collider col)
    {
        transform.position = new Vector3(0, -1000, 0);
        CoinAudio.Play();
        GlobalCoins.CoinCount += 1;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
