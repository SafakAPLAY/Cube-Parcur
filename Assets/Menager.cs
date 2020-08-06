using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menager : MonoBehaviour
{
    public static Menager instance;
    protected string classDefinition;
    protected int level=1;
    private void Awake()
    {
        MakeSingleton();
    }
    public void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance  = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        classDefinition = "Menager";
        ShowClassDefinion();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected void ShowLevel()
    {
        Debug.Log("Your level is ="+level.ToString());
    }
    protected void ShowClassDefinion()
    {
        Debug.Log("Class " + classDefinition + " is active");
    }
}
