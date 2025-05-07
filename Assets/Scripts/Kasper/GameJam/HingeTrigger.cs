using System;
using UnityEngine;

public class HingeTrigger : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;
    private bool triggered = false;

    private float ButtonStartPosition;
    public Transform button;

    void Start()
    {
        ButtonStartPosition = button.transform.position.y;
}

    void OnTriggerEnter(Collider other)
    {
        triggered = true;
        print(other.name);
    }
    void OnTriggerExit(Collider other)
    {
        triggered = false;
        print("exit true");
        print(triggered);
    }

    private void Update()
    {
        // Button movement
        if (triggered && transform.position.y > 0)
        {
            button.transform.position -= Vector3.up * (Time.deltaTime * speed);
        }
        if (!triggered && transform.position.y < ButtonStartPosition)
        {
            button.transform.position += Vector3.up * (Time.deltaTime * speed);
        }
    }
}
