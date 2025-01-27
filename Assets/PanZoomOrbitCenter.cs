using UnityEngine.EventSystems;
using UnityEngine;
using Unity.VisualScripting;

public class PanZoomOrbitCenter : MonoBehaviour
{
    private float rotationSpeed = 500.0f;
    private Vector3 mouseWorldPosStart;
    private float zoomScale = 5.0f;
    private float zoomMin = 0.5f;
    private float zoomMax = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Check for Orbit, Pan, Zoom
        if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject()) //Check for orbit
        {
            CamOrbit();
        }
        if (Input.GetMouseButtonDown(2) && !EventSystem.current.IsPointerOverGameObject()) //Check for Pan
        {
            mouseWorldPosStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
       /* if (Input.GetMouseButton(1) && !EventSystem.current.IsPointerOverGameObject())
        {
            Pan();
        }*/
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Zoom(Input.GetAxis("Mouse ScrollWheel")); //Check for Zoom
        }
    }


    private void CamOrbit()
    {
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            float verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.right, -verticalInput);
            transform.Rotate(Vector3.up, horizontalInput, Space.World);
        }
    }

 /*   void Pan()
    {
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            Vector3 mouseWorldPosDiff = mouseWorldPosStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += mouseWorldPosDiff;
        }
    }*/

    void Zoom(float zoomDiff)
    {
        if (zoomDiff != 0)
        {
            mouseWorldPosStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView - zoomDiff * zoomScale, zoomMin, zoomMax);
            Vector3 mouseWorldPosDiff = mouseWorldPosStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += mouseWorldPosDiff;
        }
    }

}