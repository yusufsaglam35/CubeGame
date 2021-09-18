using UnityEngine;
using UnityEngine.SceneManagement;
public class Control : MonoBehaviour
{
     public GameObject taptoplay;
    void Start()
    {
          if ( PlayerPrefs.GetInt("SaveLevel")>0)
            {
                 taptoplay.SetActive(false);
            }
    }

}
