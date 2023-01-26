using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float movePipe = 5;
    public float deadZone = -33;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movePipe) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Destroyed");
            Destroy(gameObject);
        }
        
    }
}
