using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Rotate(135, 270, 180);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
