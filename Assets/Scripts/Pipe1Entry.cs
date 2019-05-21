using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe1Entry : MonoBehaviour
{

    public GameObject PipeEntry;
    public int StoodOn;
    public int temp = 0;
    public GameObject MainCamera;
    public GameObject SecondCamera;
    public GameObject FadeScreen;

    public GameObject MainPlayer;
    public AudioSource PipeSound;
    void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
    }

    void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (StoodOn == 1)
            {
                this.transform.position = new Vector3(0, -1000, 0);
                temp = 1;
                StartCoroutine(WaitingForPipe());
            }
        }
    }

    IEnumerator WaitingForPipe()
    {
        PipeSound.Play();
        FadeScreen.SetActive(true);
        PipeEntry.GetComponent<Animator>().enabled = true;
        temp = 2;
        yield return new WaitForSeconds(1.5F);
        FadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.44F);
        FadeScreen.GetComponent<Animator>().enabled = false;
        PipeEntry.GetComponent<Animator>().enabled = false;
        temp = 3;
        SecondCamera.SetActive(true);
        MainCamera.SetActive(false);
        MainPlayer.transform.position = new Vector3(11.41F, -13F, 0.5F);
        FadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.44F);
        FadeScreen.GetComponent<Animator>().enabled = false;
        FadeScreen.SetActive(true);
    }

}
