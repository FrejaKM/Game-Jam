using System;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;
    private bool triggered = false;
    public float TriggerHeight = 2f;

    private float startPosition;

    void Start()
    {
        startPosition = target.position.y;
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
    }

    private void Update()
    {
        if (target.transform.position.y < TriggerHeight && triggered)
        {
            target.transform.position += Vector3.up * (Time.deltaTime * speed);
        }
        if (target.transform.position.y > startPosition && !triggered)
        { 
            target.transform.position -= Vector3.up * (Time.deltaTime * speed);
        }
    }
}
