
using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private PlayerShoot _playerShoot;
    private int _layerFloor;


    private Rigidbody rb;

    [SerializeField]
    private GameObject gun;

    void Start()
    {
        _layerFloor = LayerMask.GetMask("Floor");
    }

    void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerShoot = GetComponent<PlayerShoot>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerFloor))
        {
            _playerMovement.LookAt(hit.point);
        }
        if (Input.GetMouseButtonDown(0))
        {
            _playerShoot.Shoot(gun.transform);
        }

        if (Input.GetMouseButton(1))
        {
            _playerShoot.Shoot(gun.transform);
        }

        
    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("LoseScene");
            print("Hey");
        }
    }

}
