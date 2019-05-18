using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over2Menu : MonoBehaviour
{

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(4);
        GlobalLives.LivesAmount += 3;
        Application.LoadLevel(2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
