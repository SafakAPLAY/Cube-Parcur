using UnityEngine;


public class PlayerMenager : MonoBehaviour
{
    float secondX;
    float secondy;
    float secondz;

    Vector3 up = new Vector3(0f, 0f, 1.0f);
    Vector3 down = new Vector3(0f, 0f, -1.0f);
    Vector3 rigth = new Vector3(1.0f, 0f, 0f);
    Vector3 left = new Vector3(-1.0f, 0f, 0f);
    Vector3 startPos;
    public Transform transformTarget;
    private void Start()
    {
        transformTarget = GameObject.Find("Player").transform;
        startPos = GameObject.Find("Player").transform.position;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("KeyCode.UpArrow was pressed");
            transformTarget.position = transformTarget.position+up;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("KeyCode.DownArrow was pressed");
            transformTarget.position = transformTarget.position + down;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("KeyCode.LeftArrow was pressed");
            transformTarget.position = transformTarget.position + left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("KeyCode.RightArrow was pressed");
            transformTarget.position = transformTarget.position + rigth;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("respawned");
            transformTarget.transform.position = startPos;
        }

    }
}
