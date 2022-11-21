using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float speed = 0;
    Vector2 start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            start = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 end = Input.mousePosition;
            float i = end.x - start.x;
            speed = i / 500.0f;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(speed, 0, 0);
        speed *= 1.0f;


    }
}
