using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgent : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Transform Target;
    public bool Animated;
    public float RDistance;
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        GameObject player = GameObject.FindWithTag("Player");
        Target = player.transform;
        if (Animated)
        {
            Anim = gameObject.GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Agent.destination = Target.position;
        if (Anim && Animated)
        {
            if (Agent.remainingDistance <= 9)
            {
                Anim.SetBool("IsWalking", false);
            }
            else
            {
                Anim.SetBool("IsWalking", true);
            }
        }
    }
}