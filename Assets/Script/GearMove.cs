using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearMove : MonoBehaviour
{
    public int speed;
    void Update()
    {
        transform.Rotate(0,0,speed*Time.deltaTime*5);
    }
}
