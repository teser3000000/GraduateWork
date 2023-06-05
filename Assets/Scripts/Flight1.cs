using UnityEngine;
using System.Collections;
public class Flight1 : MonoBehaviour
{
    public Vector3 direction;
    public float acceleration;
    public Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    } 
    


    private void FixedUpdate()
    {
        rb.AddForce(direction.normalized * acceleration);
        rb.drag = 20;
    }
}
