using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform target;

    private Vector3 offsetPosition = new Vector3(0, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offsetPosition = target.position + transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offsetPosition;
    }
}
