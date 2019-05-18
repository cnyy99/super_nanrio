using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDeath : MonoBehaviour
{
    public GameObject Monster;
    IEnumerator OnTriggerEnter(Collider col)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Monster.GetComponent<Monster01Move>().enabled = false;
        Monster.transform.localScale -= new Vector3(0, 0.8f, 0);
        Monster.transform.localPosition -= new Vector3(0, 0.4f, 0);
        yield return new WaitForSeconds(1);
        Monster.transform.position = new Vector3(0, -1000, 0);
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
