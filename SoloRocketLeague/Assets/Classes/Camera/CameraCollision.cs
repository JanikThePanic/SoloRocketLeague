using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    public float MaxDistance = 5f;
    public float Smoothing = 10f;
    private Vector3 Direction;
    private float Distance;

    // Start is called before the first frame update
    void Start()
    {
        Direction = transform.localPosition.normalized;
        Distance = Direction.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredCameraPosition = transform.parent.TransformPoint(Direction * MaxDistance);
        RaycastHit hitObject;
        if(Physics.Linecast(transform.parent.position, desiredCameraPosition, out hitObject))
        {
            Distance = Mathf.Clamp((hitObject.distance*0.85f), 3.0f, MaxDistance);
        }
        else
        {
            Distance = MaxDistance;
        };

        transform.localPosition = Vector3.Lerp(transform.localPosition, Direction * Distance, Time.deltaTime * Smoothing);
    }
}
