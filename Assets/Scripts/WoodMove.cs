using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodMove : MonoBehaviour
{
    public float ResetPoint =7F;
    public float CurrentPoint;
    // Update is called once per frame

    void Update()
    {
        CurrentPoint = transform.position.y;
        if (CurrentPoint >= ResetPoint)
        {
            transform.position=new Vector3(transform.position.x,-3.95F,transform.position.z);
        }
        transform.Translate(Vector3.up * Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
