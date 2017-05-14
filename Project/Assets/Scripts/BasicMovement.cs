using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicMovement : MonoBehaviour {

    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform targetObject;

    private void Awake ()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        targetObject = GameObject.Find("MoveTarget_1").transform;
    }

    // Use this for initialization
    void Start ()
    {
        navMeshAgent.destination = targetObject.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
