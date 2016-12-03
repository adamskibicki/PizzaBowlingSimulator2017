using UnityEngine;
using System.Collections;

public class SoundBall : MonoBehaviour {

	public GameObject bowlingSound;
	private AudioSource audioSource;

	private void OnCollisionEnter(Collision other)
	{
		if (other.collider.tag == "Track")
		{
			audioSource = bowlingSound.GetComponent<AudioSource>();
			audioSource.Play ();
		}
	}
}
