using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    Vector3 touchStart;
    [SerializeField] float zoomOutMin = 1;
    [SerializeField] float zoomOutMax = 0;
    [SerializeField] GameObject newsPaper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (newsPaper.activeSelf)
        {


            if (Input.GetMouseButtonDown(0))
            {
                touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            if (Input.GetMouseButton(0))
            {
                Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Camera.main.transform.position += direction;
            }
            Zooming(Input.GetAxis("Mouse ScrollWheel"));
        }
    }

    void Zooming(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
