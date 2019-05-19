using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1End : MonoBehaviour
{
    public GameObject FadeScreen;
    public GameObject ThePlayer;

    IEnumerator OnTriggerEnter()
    {
        FadeScreen.SetActive(true);
        FadeScreen.GetComponent<Animator>().enabled = true;
        GlobalScore.CurrentScore+=TimeCount.TimeLeft*10;
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;
        Application.LoadLevel(4);
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
