using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarControl : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform end;
    [SerializeField] Slider slider;
    float maxDistance;
  
    void Start()
    {
        maxDistance = getDistance();
    }
    void Update()
    {
        if (Player.position.z <=maxDistance && Player.position.z <= end.position.z )
        {
            float distance = 1-(getDistance()/maxDistance);
            setProgressBar(distance);
        
        }
       
    }

    float getDistance()
    {
        return Vector3.Distance(Player.position,end.position);
    }
    void setProgressBar(float p)
    {
        slider.value = p;
    }
}
