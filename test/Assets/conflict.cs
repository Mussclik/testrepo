using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conflict : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(1,1,1);
        cube.transform.Translate(3, 3, 3);
        Vector3 move = new Vector3(1, 1, 1);
        cube.transform.Translate(move);
    }
}
