using UnityEngine;

public class OppositeVehicles : MonoBehaviour
{
    public GameObject Opposite_Vehicle;
    public float speed = 10.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Opposite_Vehicle, new Vector3(-7.5f, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
