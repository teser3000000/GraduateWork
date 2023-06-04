using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connection : MonoBehaviour
{
    public GameObject[] objects;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ConnectObject")
        {
            Destroy(gameObject);
            Debug.Log("Столкновение");
            Instantiate(objects[0], objects[0].transform.position, Quaternion.identity);
        }
    }
}
