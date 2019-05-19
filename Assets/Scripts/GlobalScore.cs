using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GlobalScore : MonoBehaviour
{
    static public int CurrentScore;
    public int InternalScore;
    public GameObject ScoreText;

    // Update is called once per frame
    void Update()
    {
        InternalScore = CurrentScore;
        ScoreText.GetComponent<Text>().text = "分数: " + InternalScore;
    }
    // Start is called before the first frame update
    void Start()
    {

    }


}
