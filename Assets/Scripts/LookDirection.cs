using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookDirection : MonoBehaviour
{
    private float rotateXSpeed=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, (transform.localEulerAngles.y + mouseX)*rotateXSpeed, transform.localEulerAngles.z);
    }
}
