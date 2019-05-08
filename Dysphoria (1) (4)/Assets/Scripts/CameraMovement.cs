using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothSpeed = 10f;
    [SerializeField] float minX;
    [SerializeField] float maxX;

    private void LateUpdate()
    {
        Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        if (transform.position.x <= minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }

    }

}
