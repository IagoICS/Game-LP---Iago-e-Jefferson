using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
     public Transform target;
    public Vector3 offset;
    public float smoothCamera;
    public Vector3 minValues, maxValue;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        Follow();
    }

    // Update is called once per frame
     void Follow()
    {
     Vector3 targetPosition = target.position + offset;

          Vector3 boundPosition = new Vector3(
              Mathf.Clamp(targetPosition.x,minValues.x,maxValue.x),
                Mathf.Clamp(targetPosition.y,minValues.y,maxValue.y),
                Mathf.Clamp(targetPosition.z,minValues.z,maxValue.z));

        Vector3 smoothPosition = Vector3.Lerp(transform.position, boundPosition,smoothCamera*Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}
