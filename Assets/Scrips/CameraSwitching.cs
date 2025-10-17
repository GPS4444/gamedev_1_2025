using System.Runtime.ExceptionServices;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    public Camera Main_Camera;
    public Camera Alt_Camera;
    public bool Switch = true;

    public void ft_switch_camera() 
    {
        Main_Camera.enabled = !Switch;
        Alt_Camera.enabled = Switch;
        Switch = !Switch;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            ft_switch_camera();
        }
    }
}
