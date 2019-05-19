using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject BackWall;

    void OnTriggerEnter()
    {
        MainCamera.GetComponent<CameraFollow>().enabled = false;
        BackWall.SetActive(true);
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
