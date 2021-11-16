using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotationSpeed;
    public float rotateXValue;
    public float rotateYValue;
    public float rotateZValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotateXValue, rotateYValue, rotateZValue), rotationSpeed * Time.deltaTime);
    }
}
