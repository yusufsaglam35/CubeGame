using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class MenuControl : MonoBehaviour
{
    [SerializeField] private GameObject slider;
    public CanvasGroup target, target2;
    public float speed = 2f;
    private float _t = 0f;
    public int savelevel;
    public int getsave;

    public void Update()
    {
        effect();
    }
    public void Start()
    {
        //PlayerPrefs.DeleteAll();
        Load_Control();
    }

    public void Load_Control()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            Save();
        }
    }

    void effect()
    {
        _t += Time.deltaTime * speed;
        target.alpha = Mathf.PingPong(_t, 1f);
        target2.alpha = Mathf.PingPong(_t, 1f);
    }

    public void refresh()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void GoToLevel()
    {
        SceneManager.LoadScene(24);
    }

    public void Save()
    {
        savelevel = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SaveLevel", savelevel);
    }
    public void ContinueButton()
    {
        getsave = PlayerPrefs.GetInt("SaveLevel");
        SceneManager.LoadScene(getsave);
    }
    public void SliderOpen()
    {
        slider.SetActive(true);
    }
}



