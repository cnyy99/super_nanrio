using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuesBlock01 : MonoBehaviour
{
    public GameObject QBlock;
    public GameObject DeadBlock;
    public GameObject Mushroom;

    IEnumerator OnTriggerEnter(Collider col)
    {
        QBlock.SetActive(false);
        DeadBlock.SetActive(true);
        yield return new WaitForSeconds(0.2F);
        Mushroom.SetActive(true);
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
