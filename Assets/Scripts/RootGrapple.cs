using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootGrapple : MonoBehaviour
{ public LineRenderer root;
    public Camera mainCamera;
    public DistanceJoint2D anchorPoint;

    // Start is called before the first frame update
    void Start()
    {
        anchorPoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // get the mouse position and draw a line with line renderer
            Vector2 mousePosition = (Vector2) mainCamera.ScreenToWorldPoint(Input.mousePosition);
            root.SetPosition(0, mousePosition);
            root.SetPosition(1, this.transform.position);

            // get the mouse position and set it as an anchor point
            anchorPoint.connectedAnchor = (Vector3)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            anchorPoint.enabled = true;
            root.enabled = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // disable the line renderer abd anchor point is the mouse button is up
            anchorPoint.enabled = false;
            root.enabled = false;
        }

        if (anchorPoint.enabled)
        {
            root.SetPosition(1, this.transform.position);
        }
    }
}
