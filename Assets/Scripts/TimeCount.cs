using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;

public class TimeCount : MonoBehaviour
{

    public int TotalTime = 301;

    public static int TimeLeft;
    public GameObject TimeText;
    public int CalculatingTime;
    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject CameraFollow;
    public GameObject Player;
    public int KeepZero;

    // Update is called once per frame
    void Update()
    {
        TimeLeft = TotalTime;
        if (KeepZero == 0)
        {
            TimeText.GetComponent<Text>().text = "" + TotalTime;
        }

        if (CalculatingTime == 0)
        {
            StartCoroutine(DeductTime());
        }

        if (TotalTime == 0)
        {
            StartCoroutine(TimeUp());
        }
    }

    IEnumerator DeductTime()
    {
        CalculatingTime = 1;
        TotalTime -= 1;
        yield return new WaitForSeconds(1F);
        CalculatingTime = 0;
    }

    IEnumerator TimeUp()
    {
        TotalTime -= 1;
        KeepZero = 1;
        TimeText.GetComponent<Text>().text = "0";
        GlobalLives.LivesAmount -= 1;
        LevelMusic.SetActive(false);
        DeathSound.Play();
        CameraFollow.GetComponent<CameraFollow>().enabled = false;
        Player.GetComponent<ThirdPersonUserControl>().enabled = false;
        Player.GetComponent<ThirdPersonCharacter>().enabled = false;
        Player.GetComponent<CapsuleCollider>().enabled = false;
        GlobalScore.CurrentScore = 0;
        yield return new WaitForSeconds(3);
        Application.LoadLevel(4);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
