using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public bool esponenzialSpeed;
    public float rotatingSpeed = 30f;
    public float maxRotatingSpeed = 30000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (esponenzialSpeed)
        {
            rotatingSpeed = rotatingSpeed + (Time.deltaTime * rotatingSpeed) * 0.1f;

            if (rotatingSpeed > maxRotatingSpeed)
            {
                rotatingSpeed = maxRotatingSpeed;
            }
        }
        transform.Rotate(0, rotatingSpeed*Time.deltaTime, 0);
    }
}
