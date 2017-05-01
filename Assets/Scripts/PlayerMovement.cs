using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public void LookAt(Vector3 point)
    {
        Vector3 heightCorrectedPoint = new Vector3(point.x, transform.position.y, point.z);
        transform.LookAt(heightCorrectedPoint);
    }
}
