using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fizyka : MonoBehaviour {
	Rigidbody rig;
	public float speed;
	float inputX, inputZ;
	bool jump = false;
	bool shot = false;
	public GameObject sphere;
	public Transform barrel;
	void Awake()
    {
		rig = GetComponent<Rigidbody>();
    }
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		inputX = Input.GetAxis("Horizontal");
		inputZ = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Jump"))
        {
			jump = true;
        }
		if (Input.GetButtonDown("Fire1"))
		{
			shot = true;
		}
	}

	void FixedUpdate()
    {
		rig.velocity = new Vector3(inputX*speed,rig.velocity.y,inputZ*speed);
        if (jump)
        {
			Jump();
			jump = false;
        }
		if (shot)
		{
			Shot();
			shot = false;
		}
	}

	void Jump()
	{
		rig.AddForce(0, 300, 0);
	}
	void Shot()
	{
		GameObject newSphere = Instantiate(sphere, barrel.position, Quaternion.identity);
		newSphere.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 30) ;
	}
}
