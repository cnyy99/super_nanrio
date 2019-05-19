using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;

public class Level1Death : MonoBehaviour
{

    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject Player;
    public GameObject CameraFollow;

    IEnumerator OnTriggerEnter(Collider col)
    {
        GlobalLives.LivesAmount -= 1;
        LevelMusic.SetActive(false);
        DeathSound.Play();
        CameraFollow.GetComponent<CameraFollow>().enabled = false;
        Player.GetComponent<ThirdPersonUserControl>().enabled = false;
        Player.GetComponent<ThirdPersonCharacter>().enabled = false;
        Player.transform.localScale -= new Vector3(0, 0.6F, 0);
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
