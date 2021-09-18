using UnityEngine;

public class Resolution : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(Screen.currentResolution.width/2, Screen.currentResolution.height/2,true);
    }

}
