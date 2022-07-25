using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bulletprefab;
    public float bulletdelay = 0.5f;
    void Start()
    {
        Invoke("Bulletshooter", bulletdelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Bulletshooter()
    {
        Instantiate(Bulletprefab, transform);
    }
    
}
