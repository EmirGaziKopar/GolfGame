using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBall : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            BallRotate(Input.GetAxis("Mouse X"));
        }
        
    }

    public void BallRotate(float XaxisRotation)
    {
        transform.Rotate(Vector3.forward, -XaxisRotation * rotationSpeed); //rotate the camera
    }
}
