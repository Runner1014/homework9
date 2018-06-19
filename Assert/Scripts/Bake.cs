using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bake : MonoBehaviour {
    private NavMeshAgent tank;
    public Transform target;
	// Use this for initialization
	void Start () {
        tank = gameObject.GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        tank.SetDestination(target.position);
    }
}
