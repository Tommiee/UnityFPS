using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_attack : MonoBehaviour {

    public Transform Player;
    [SerializeField]
    private int MoveSpeed = 3;
    private int MaxDist = 10;
    [SerializeField]
    private float MinDist = 1;

    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
    }
}
