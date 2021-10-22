using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    [SerializeField]
    Transform[] targets;
    int targetIndex = 0;
    Transform currenttarget;

    [SerializeField]
    float speed;

    [SerializeField]
    float dist;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTarget();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, currenttarget.position, speed);

        if(Vector3.Distance(transform.position, currenttarget.position) < dist)
        {
            targetIndex++;
            if (targetIndex >= targets.Length)
                targetIndex = 0;
            UpdateTarget();
        }
    }

    void UpdateTarget()
    {
        currenttarget = targets[targetIndex];
    }
}
