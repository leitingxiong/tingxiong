using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    public float soothSpeed;
    public float rotationSpeed;
    public float currentRotation ;
    void LateUpdate()
    {
        Vector3 targetPosition = target.position+ new Vector3(0,0,-5) ;
        transform.position = Vector3.Lerp(transform.position, targetPosition, soothSpeed);
        if (Input.GetMouseButton(1))
        {
            currentRotation += Input.GetAxis("Mouse X") * rotationSpeed;
        }

        Quaternion rotation = Quaternion.Euler(0, currentRotation, 0f);
        transform.rotation = rotation;
    }
}
