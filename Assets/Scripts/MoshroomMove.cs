using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoshroomMove : MonoBehaviour
{
    public GameObject ActualMushroom;
    public GameObject ThisMushroom;

    // Update is called once per frame
    void Update()
    {
        transform.parent = null;
        transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
        StartCoroutine(CloseAnim());
    }

    IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(0.4f);
        ActualMushroom.SetActive(true);
        ThisMushroom.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
