using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoshroomCollect : MonoBehaviour
{
    public AudioSource GrowSound;
    public GameObject ThePlayer;
    public GameObject Moshroom;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GrowSound.Play();
            Moshroom.transform.position = new Vector3(0, -1000, 0);
            ThePlayer.transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
        }
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
