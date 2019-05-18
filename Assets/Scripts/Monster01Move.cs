using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster01Move : MonoBehaviour
{
    public float LeftPoint = 12.98F;
    public float RightPoint = 32.18F;
    public int Direction = 1;  //  1 = moving right, 2 = moving left

    // Update is called once per frame
    void Update()
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
            Direction = 1;
        }
        if (this.transform.position.x > RightPoint)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            Direction = 2;
        }
        if (Direction == 2)
        {
            transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
            Direction = 2;
        }
        if (this.transform.position.x < LeftPoint)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
            Direction = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
