using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] private int weight = 2;
    [SerializeField] private float refresh_speed = 1, refresh_speed2 = 1.5f;
    [SerializeField] GameObject Obstacle1, Obstacle2, Obstacle3, Obstacle4, Obstacle5, Obstacle6, Obstacle7, Obstacle8;

    void FixedUpdate()
    {
        Move1();
        Move4();
        Move6();
        Invoke("Move2", 1.5f);
        Invoke("Move3", 2f);
        Invoke("Move5", 2f);

    }

    public void Move1()
    {
        float x = Mathf.Sin(Time.time * refresh_speed) * weight;
        float y = Obstacle1.transform.position.y;
        float z = Obstacle1.transform.position.z;
        Obstacle1.transform.position = new Vector3(x, y, z);
    }
    public void Move2()
    {
        float x = Mathf.Sin(Time.time * refresh_speed2) * weight;
        float y = Obstacle2.transform.position.y;
        float z = Obstacle2.transform.position.z;
        Obstacle2.transform.position = new Vector3(x, y, z);
    }
    public void Move3()
    {
        float x = Mathf.Sin(Time.time * refresh_speed) * weight;
        float y = Obstacle3.transform.position.y;
        float z = Obstacle3.transform.position.z;
        Obstacle3.transform.position = new Vector3(x, y, z);
    }
    public void Move4()
    {
        float x = Mathf.Sin(Time.time * refresh_speed) * weight;
        float y = Obstacle4.transform.position.y;
        float z = Obstacle4.transform.position.z;
        Obstacle4.transform.position = new Vector3(x, y, z);
    }
    public void Move5()
    {
        float x = Mathf.Sin(Time.time * refresh_speed2) * weight;
        float y = Obstacle5.transform.position.y;
        float z = Obstacle5.transform.position.z;
        Obstacle5.transform.position = new Vector3(x, y, z);
    }
    public void Move6()
    {
        float x = Mathf.Sin(Time.time * refresh_speed) * weight;
        float y = Obstacle6.transform.position.y;
        float z = Obstacle6.transform.position.z;
        Obstacle6.transform.position = new Vector3(x, y, z);
    }
    public void Move7()
    {
        float x = Mathf.Sin(Time.time * refresh_speed) * weight;
        float y = Obstacle7.transform.position.y;
        float z = Obstacle7.transform.position.z;
        Obstacle7.transform.position = new Vector3(x, y, z);
    }
    public void Move8()
    {
        float x = Mathf.Sin(Time.time * refresh_speed) * weight;
        float y = Obstacle8.transform.position.y;
        float z = Obstacle8.transform.position.z;
        Obstacle8.transform.position = new Vector3(x, y, z);
    }
}
