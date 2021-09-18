﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControls : MonoBehaviour {

	//GameObject[] goalLocations;
	UnityEngine.AI.NavMeshAgent agent;
    Animator anim;
    Vector3 lastGoal;


	// Use this for initialization
	void Start () {
		//goalLocations = GameObject.FindGameObjectsWithTag("goal");
		agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetBool("isWalking", true);
        PickGoalLocation();
	}

    void PickGoalLocation()
    {
        lastGoal = agent.destination;
        GameObject goalObject = PeopleMovement.Singleton.GetRandomGoalPositions();
        agent.SetDestination(goalObject.transform.position);
        //agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
    }

	
	// Update is called once per frame
	void Update () {
        if (agent.remainingDistance < 1) //At the goal
        {
            PickGoalLocation();
        }
        foreach (var item in PeopleMovement.Singleton.Obstacles)
        {
            float distance = Vector3.Distance(item.transform.position, this.transform.position);
            if ( distance< 5&& Random.Range(0,100)<5)
            {
                agent.SetDestination(lastGoal);
            }else if (distance < 1)
            {
                PeopleMovement.Singleton.RemoveObstacles(item);
                break;
            }
        }
	}
}
