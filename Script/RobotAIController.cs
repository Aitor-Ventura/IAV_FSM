using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAIController : MonoBehaviour
{
    [Header("Prefab references")]
    public GameObject bulletPrefab;
    
    [Header("References to in game objects")]
    public GameObject player;
    public GameObject gun;

    [Header("Settings")] 
    public float health = 100f;
    
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat($"distance", Vector3.Distance(transform.position, player.transform.position));
        _animator.SetFloat($"health", health);
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health -= 10f;
        }

        if (health <= 20)
        {
            health += 0.01f;
        }
        
        Debug.Log("Health: " + health);
    }
    
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(gun.transform.right * 1000);
    }

    public void StartShooting()
    {
        InvokeRepeating(nameof(Shoot), 0.5f, 0.5f);
    }

    public void StopShooting()
    {
        CancelInvoke(nameof(Shoot));
    }
}
