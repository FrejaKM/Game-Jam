using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 1f;

    public float jump_height = 100f;
     //private Vector3 forward = (1, 0, 0);
     
     public Transform target;

    private Rigidbody _rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    
    _rigidbody = GetComponent<Rigidbody>();
    
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddForce(Vector3.left * speed);
        } 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody.AddForce(Vector3.back * speed);
        } 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddForce(Vector3.right * speed);
        } 
        
        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= 0.51)
        {
            _rigidbody.AddForce(Vector3.up * jump_height);
        } 
    }
}
