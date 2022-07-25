using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletspeedandTrajectory : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 bulletDirection= new Vector3(0f,0f,1f);
    public float bulletSpeed = 12f; 
    public float bulletDamage = 2f;
    public float hp= 4f;
    void Start()
    {
       
    }

    private void Bulletmovement()
    {
        transform.localPosition += bulletDirection * Time.deltaTime * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Bulletmovement();
    }
    void Damage() {
        hp = hp-bulletDamage;

      }
     }

    
