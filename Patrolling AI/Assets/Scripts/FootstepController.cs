using UnityEngine;
using System.Collections;

public class FootstepController : MonoBehaviour {

	protected AudioSource audio;
	private double footstepDelay;
	private double timeUntilStep;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		timeUntilStep = 0;
		footstepDelay = 0.125;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (timeUntilStep <= 0) {
			audio.Play ();
			timeUntilStep = 60 * footstepDelay;
		}
		timeUntilStep--;
	}
}
