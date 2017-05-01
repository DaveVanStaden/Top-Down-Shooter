using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed;
    Vector3 TargetPostion = new Vector3(0, 1, 0);
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player 1");
        TargetPostion = player.transform.position;
    }


    void Update()
    {
        player = GameObject.Find("Player 1");
        TargetPostion = player.transform.position;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, TargetPostion, step);
    }
}


