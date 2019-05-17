using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe1Entry : MonoBehaviour
{

    public GameObject PipeEntry;
    public int StoodOn;
    public int temp = 0;

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
        if (Input.GetButtonDown("GoDown"))
        {
            if (StoodOn == 1)
            {
                //GameObject.Find("FPSController").GetComponent<"FirstPersonController">().enabled=false;
                this.transform.position = new Vector3(0, -1000, 0);
                // PipeEntry.GetComponent<Animator>().enabled = true;
                temp = 1;
                StartCoroutine(WaitingForPipe());
                temp = 4;
            }
        }
    }

    IEnumerator WaitingForPipe()
    {
        PipeEntry.GetComponent<Animator>().enabled = true;
        temp = 2;
        yield return new WaitForSeconds(2.0F);
        PipeEntry.GetComponent<Animator>().enabled = false;
        temp = 3;
        //GameObject.Find("FPSController").GetComponent<"FirstPersonController">().enabled=true;
    }

}
