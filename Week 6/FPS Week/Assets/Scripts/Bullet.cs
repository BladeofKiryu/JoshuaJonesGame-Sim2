using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]
    float bulletlifetime;

    float elapsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= bulletlifetime)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        GameManager.instance.score -= 1;
    }
}
