using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject projectilePrefab;
    public float fireRate = 0.25f;

    private float nextFire = 0f;

    void Update()
    {
        HandleMovement();
        HandleShooting();
    }

    private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, moveY, 0f) * moveSpeed * Time.deltaTime;
        transform.position += movement;
    }

    private void HandleShooting()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextFire)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
