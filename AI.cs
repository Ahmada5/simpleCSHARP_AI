using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI2 : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    public float radius;
    Rigidbody rb;
    Animator animator;


    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        if (!agent.hasPath)
        {
            agent.SetDestination(GETPOINT.Instance.GetRandomPoint(transform, radius));
            animator.SetBool("walk", false);

            Debug.Log("tidakjalan");
        }
        else if (agent.hasPath)
        {
            animator.SetBool("walk", true);
 
            Debug.Log("jalan");
        }
    }




}
