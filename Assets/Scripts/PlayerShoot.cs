using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;

    public void Shoot(Transform position)
    {
        GameObject projectileInstance = Instantiate(projectile);

        projectileInstance.transform.position = position.position;
        projectileInstance.transform.rotation = position.rotation;
    }
}