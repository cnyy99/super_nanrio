using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GlobalLives : MonoBehaviour
{
    public static int LivesAmount = 3;
    public int InternalLives;
    public GameObject LifeTextBox;

    // Update is called once per frame
    void Update()
    {
        InternalLives = LivesAmount;
        LifeTextBox.GetComponent<Text>().text = "生命: " + InternalLives;

        if (InternalLives <= 0)
        {
            StartCoroutine(GameOverScene());
        }

    }

    IEnumerator GameOverScene()
    {
        yield return new WaitForSeconds(2.9f);
        Application.LoadLevel(3);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
