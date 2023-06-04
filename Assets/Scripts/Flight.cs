using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    public float flySpeed;
    private float horizontalMovement;
    private float Amount = 120;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        flySpeed = 0f;
        rb.useGravity = true;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
       if(Input.GetKey(KeyCode.F) && flySpeed < 100)
        {
            flySpeed += 0.75f;
        }
       if(flySpeed >= 50)
        {
            rb.useGravity = false;
            movement();
        }
        if (Input.GetKey(KeyCode.G) && flySpeed > 51)
        {
            flySpeed -= 0.5f;
        }
    }
    public void movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        horizontalMovement += horizontal * Amount * Time.deltaTime;
        float verticalMovement = Mathf.Lerp(0, 20, Mathf.Abs(vertical)) * Mathf.Sign(vertical);
        float roll = Mathf.Lerp(0, 30, Mathf.Abs(horizontal)) * -Mathf.Sign(horizontal);

        transform.localRotation = Quaternion.Euler(Vector3.up * horizontalMovement + Vector3.right * verticalMovement + Vector3.forward * roll);
    }
}
