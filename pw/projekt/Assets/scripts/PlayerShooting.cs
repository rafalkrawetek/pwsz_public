using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
	public GameObject pocisk;
	public Transform lufa;
	bool shot = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (!GameObject.Find("GameController").GetComponent<GameController>().IsGameStarted())
		{
			return;
		}
		if (Input.GetButtonDown("Fire1"))
		{
			shot = true;
		}
	}

	void FixedUpdate () {
        if (shot)
        {
			Shot();
			shot = false;
        }
	}
	void Shot()
    {
		GameObject nowypocisk = Instantiate(pocisk, lufa.position, lufa.rotation);
		nowypocisk.GetComponent<Transform>().parent = transform;
		nowypocisk.GetComponent<Rigidbody>().velocity = nowypocisk.transform.forward * 50;
	}
}
