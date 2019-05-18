using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public float DistanceFromPlayer = 10;
    public float StaticCameraY = 3;
    public float DistanceInFrontOfPlayer = 4;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.z = Player.position.z - DistanceFromPlayer;
        temp.x = Player.position.x + DistanceInFrontOfPlayer;
        transform.position = temp;
    }
}
