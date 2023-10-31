using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlongLine : MonoBehaviour
{
    // Start is called before the first frame update
    //public LineRenderer lineRenderer = NavMeshLine.lineRendererSmall;
    public static LineRenderer lineRenderer;

    // public LineRenderer lineRenderer = NavMeshLine.Instance.lineRendererSmall; //now uses specific instance from NavMeshLine
    public float speed = 1.0F; 

    private float distanceAlongLine = 0;

    Vector3 lineDirection;
    float angle;
    Vector3 rotationAxis;
    Vector3 targetPosition;

    // private Vector3[] midpoints;

    private void Start()
    {
        lineRenderer = GameObject.Find("LineRendererBig").GetComponent<LineRenderer>();
    }

    void Update() {
    
        //distanceAlongLine += speed * Time.deltaTime;

        if (distanceAlongLine > lineRenderer.positionCount - 1) {
            distanceAlongLine = 0;
        }
        transform.position = Vector3.Lerp(lineRenderer.GetPosition(Mathf.FloorToInt(distanceAlongLine)), lineRenderer.GetPosition(Mathf.CeilToInt(distanceAlongLine)), distanceAlongLine % 1);
        transform.rotation = Quaternion.AngleAxis(angle, rotationAxis);
    }
    
}

