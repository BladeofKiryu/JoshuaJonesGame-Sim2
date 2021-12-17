using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject portal;

    [SerializeField]
    float portalSpeed;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 portalDirection = transform.forward * portalSpeed;
            GameObject b = Instantiate(portal, transform.position, transform.rotation);
            b.GetComponent<Rigidbody>().velocity = portalDirection;
        }
    }
}