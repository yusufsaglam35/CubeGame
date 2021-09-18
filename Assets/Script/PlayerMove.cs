using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Touch touch;
    public float speedtouch = 0;
    [SerializeField] public float speed = 9;
    bool StartPanel = true;
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private GameObject Ground;
    [SerializeField] private int x, y, z;


    void Start()
    {
        Instantiate(Ground);
        Time.timeScale = 1;
    }
    void FixedUpdate()
    {

        if (StartPanel == false)
        {
            Move();
            SwipeControl();
        }
    }
    public void Menucontrol()
    {
        MenuPanel.SetActive(false);
        StartPanel = false;
    }

    public void SwipeControl()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedtouch, transform.position.y, transform.position.z);
            }
        }
    }
    public void Move()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

}