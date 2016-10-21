using UnityEngine;
using System.Collections;

public class FootstepController : MonoBehaviour {

    AudioSource footstepAudio;
    public AudioClip[] footsteps;
    // Use this for initialization
    void Start () {
        footstepAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void PlayFootstep(float volume)
    {
        footstepAudio.PlayOneShot(footsteps[(int)Mathf.Floor(Random.value*8)],1);
    }
}
