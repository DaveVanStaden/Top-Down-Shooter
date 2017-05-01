using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private Rigidbody _rigidbody;

    [SerializeField]
    private float _Speed;
    public GameObject floor;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody> ();
        floor = GameObject.FindWithTag("floor");
    }

    void FixedUpdate()
    {
        Vector3 velocity = transform.forward * _Speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
