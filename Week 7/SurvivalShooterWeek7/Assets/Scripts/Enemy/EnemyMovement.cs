using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination (player.position);
        }
        else
        {
            nav.enabled = false;
        }
    }

    private void knockBack(GameObject target, Vector3 direction, float length, float overTime)
    {
        direction = direction.normalized;
        StartCoroutine(knockBackCoroutine(target, direction, length, overTime));
    }

    IEnumerator knockBackCoroutine(GameObject target, Vector3 direction, float length, float overTime)
    {
        float timeleft = overTime;
        while (timeleft > 0)
        {

            if (timeleft > Time.deltaTime)
                target.transform.Translate(direction * Time.deltaTime / overTime * length);
            else
                target.transform.Translate(direction * timeleft / overTime * length);
            timeleft -= Time.deltaTime;

            yield return null;
        }

    }
}
