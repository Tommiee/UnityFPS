using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for reading the input of the player
/// Mouse and / or Keyboard
/// </summary>
public class PlayerInput : MonoBehaviour {
    private PlayerShoot _playerShoot;
    public AudioClip _shoot;
    private AudioSource source;

    void Awake()
    {
        _playerShoot = GetComponent<PlayerShoot>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        // convert pixel coords of mouse to ray.
        // A ray is an invisible line between two points
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 100);
        
        if (Input.GetMouseButtonDown(0))
        {
            _playerShoot.Shoot();
            source.PlayOneShot(_shoot);
        }
    }
}