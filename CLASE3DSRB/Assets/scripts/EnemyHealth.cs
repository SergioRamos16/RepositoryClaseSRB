using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : Health
{
    private Animator myAnimator;
    public float timeToDie = 4;
    private NavMeshAgent agent;
    private Collider myCollider;
    public Collider HeadCollider;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponentInChildren<Animator>();
        myCollider = GetComponent<Collider>();
    }

    public override void Die()
    {
        myAnimator.SetTrigger("Death");
        agent.isStopped = true;
        myCollider.enabled = false;
        StartCoroutine(DeathCorrutine());
    }

    public IEnumerator DeathCorrutine()
    {
        yield return new WaitForSeconds(timeToDie);
        Destroy(gameObject);
    }
}