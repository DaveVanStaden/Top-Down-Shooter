using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    public Transform target;

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, transform.position.y, target.position.z), step);
    }
}

