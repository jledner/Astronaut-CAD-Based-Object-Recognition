using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonBehavior : MonoBehaviour
{
    public GameObject moon;
    public GameObject focusedObject;
    public float rayLength = 1000f;
    public Color rayColor = Color.white;
    public float torqueAmount;
    private LineRenderer lineRenderer;
    private GameObject spawnedObject; // reference to the spawned virtual object, if any

    void Start()
    {

        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startColor = rayColor;
        lineRenderer.endColor = rayColor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Compute the player's forward direction
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        // conduct raycast
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            print("touch event");
            // create a ray from the touch point
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            // cast the ray and get the hit result
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, rayLength))
            {
                print("Raycast hit detected");
                focusedObject = hit.collider.gameObject;
                if (focusedObject.CompareTag("Moon"))
                {
                    print("moon click detected");
                    moon.GetComponent<Rigidbody>().AddTorque(Vector3.up * torqueAmount, ForceMode.Impulse);
                }

                Debug.DrawRay(transform.position, ray.direction * hit.distance, Color.yellow);
            }
            else
            {
                focusedObject = null;
            }
        }
    }
}
