using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Instatiate bullets so that the player can shoot.
/// </summary>
public class PlayerShoot : MonoBehaviour
{

    [SerializeField]
    private float _fireRate;

    private float _nextFireTime;
    
    

    public void Shoot()
    {
        
        RaycastHit hit;
       
        

        if (Time.time >= _nextFireTime)
        {
           //Debug.DrawRay(transform.position, transform.forward * 20, Color.red, 2.0f);
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.collider.tag.Equals("Enemy"))
                {
                    string HitedEnemy = hit.collider.gameObject.name;
                    

                    print("Enemy hit");
                    Object.Destroy(hit.transform.gameObject);
                }
                else
                {
                    print("Hit Something else");
                }
            }
            else
            {
                print("Missed completely");
            }

            _nextFireTime = Time.time + _fireRate;
        }
    }
}

