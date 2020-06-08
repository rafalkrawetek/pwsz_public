using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletController : MonoBehaviour {
	public AudioSource shoot;
	public AudioSource hit;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 10f);
		shoot.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision)
    {
		if (collision.collider.gameObject.layer == 10 && GetComponent<Renderer>().enabled)
		{
			GameObject.Find("GameController").GetComponent<GameController>().hit(collision.collider.gameObject);
			if (GameObject.Find("GameController").GetComponent<GameController>().IsGameStarted())
				hit.Play();
		}
		
		GetComponent<Renderer>().enabled = false;
		Destroy(gameObject, 1f);
    }
}
