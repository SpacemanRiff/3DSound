using UnityEngine;
using System.Collections;

[RequireComponent (typeof (NavMeshAgent))]
[RequireComponent (typeof (Animator))]
public class MoveTo : MonoBehaviour {

	[SerializeField]
	Transform[] navPoints;

	[SerializeField]
	NavMeshAgent agent;

	public int destPoint;
	private float currTime = 0;
	private float waitTime = 3f;
	private Animator animator;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		agent.autoBraking = true; //Make sure the agent slows down and stops when it reaches a navPoint.
		agent.destination = navPoints [destPoint].position; //Go to the first position without waiting.
		animator = GetComponent<Animator>();
	}

	private void MoveToNextPoint(){
		if (currTime == 0) {
			currTime = Time.time; //Set the currTime to the time (in seconds) of how long the game has been going on.
		}
		if((Time.time - currTime) >= waitTime){
			agent.destination = navPoints [destPoint].position; //Move to next position.
			destPoint = (destPoint + 1) % navPoints.Length; //Choose next position at random
			currTime = 0;
		}
	}

	void Update(){
		if (agent.remainingDistance <= 0.1f) {
			MoveToNextPoint ();
		}
	}
}