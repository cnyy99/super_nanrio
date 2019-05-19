using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02Load : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
