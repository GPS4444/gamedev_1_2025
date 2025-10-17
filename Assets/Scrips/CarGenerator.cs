using UnityEngine;

public class CarGenerator : MonoBehaviour
{
    public GameObject Opposite_Vehicle;

    private int Alternate = -1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(Opposite_Vehicle, new Vector3((Alternate * 7.5f), 0, 0), Quaternion.identity);
            //add wait
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
