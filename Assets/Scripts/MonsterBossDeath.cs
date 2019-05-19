using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MonsterBossDeath : MonoBehaviour
{
    public GameObject Monster;
    public GameObject PlayerDeathTrigger1;
    public GameObject PlayerDeathTrigger2;
    public GameObject DuckPrincess;
    public GameObject FadeScreen;
    public GameObject WinText;
    IEnumerator OnTriggerEnter(Collider col)
    {
        DuckPrincess.SetActive(true);
        WinText.SetActive(true);
        this.GetComponent<BoxCollider>().enabled = false;
        PlayerDeathTrigger1.GetComponent<BoxCollider>().enabled = false;
        PlayerDeathTrigger2.GetComponent<BoxCollider>().enabled = false;
        Monster.transform.localScale -= new Vector3(0, 1.8f, 0);
        Monster.transform.localPosition -= new Vector3(0, 1.4f, 0);
        GlobalScore.CurrentScore += 100;
        yield return new WaitForSeconds(1);
        Monster.transform.position = new Vector3(0, -1000, 0);
        yield return new WaitForSeconds(3);
        FadeScreen.SetActive(true);
        FadeScreen.GetComponent<Animator>().enabled = true;
        GlobalScore.CurrentScore += TimeCount.TimeLeft * 10;
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;
        Application.LoadLevel(2);


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
