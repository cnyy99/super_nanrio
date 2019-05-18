using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Death : MonoBehaviour
{

    public AudioSource DeathSound;
    public GameObject LevelMusic;

    IEnumerator OnTriggerEnter(Collider col)
    {
        GlobalLives.LivesAmount -= 1;
        LevelMusic.SetActive(false);
        DeathSound.Play();
        yield return new WaitForSeconds(3);
        Application.LoadLevel(0);
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
