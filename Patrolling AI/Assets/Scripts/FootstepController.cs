using UnityEngine;
using System.Collections;

public class FootstepController : MonoBehaviour {

    AudioSource audio;
    public AudioClip[] footsteps;
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void PlayFootstep(float volume)
    {
        audio.PlayOneShot(footsteps[(int)Mathf.Floor(Random.value*8)],1);
    }
}
