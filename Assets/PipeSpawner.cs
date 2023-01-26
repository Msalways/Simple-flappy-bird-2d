using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spanRate = 2;
    private float timer = 0;

    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spanRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spanPipe();
            timer = 0;
        }
    }

    void spanPipe()
    {
        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowest,heightOffset),0), transform.rotation);
    }
}
