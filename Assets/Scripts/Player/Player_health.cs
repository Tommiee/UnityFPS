using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_health : MonoBehaviour {
    private float health = 50;
    private float damage = 1;
    public AudioClip _hit;
    private AudioSource source;

    void Awake()
    {

        source = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log(health);
            health -= damage;
            source.PlayOneShot(_hit);
        }
        if (health <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
