using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01Load : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
