using UnityEngine;

public class Test : MonoBehaviour
{
   
    [SerializeField] GameObject rul;
    [SerializeField] GameObject cube;
   
    public float one;
    public float two;
    public float tree;
    public float four;
    public float five;
    bool flight = false;

    void Start()
    {
        
    }
        
    void FixedUpdate()
    {
        tree = -0.2f;
        one = rul.transform.rotation.z;

        cube.transform.Rotate(one * 3, 0, 0);
        four = cube.transform.position.y;
        two = cube.transform.position.x;
        five = cube.transform.position.z;

        if (Input.GetKey(KeyCode.R))
        {
            flight = !flight;
            cube.transform.Rotate(0, 0, tree + tree);
            cube.transform.position = new Vector3(two, four + 0.3f, five);
        }
    }
}
