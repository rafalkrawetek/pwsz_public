using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public CharacterController controller;
	public float movementSpeed = 12f;
	public float gravity = -9.81f;
	public float jumpHeight = 3f;
	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;
	Vector3 velocity;
	bool isGrounded;
	bool jump = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameObject.Find("GameController").GetComponent<GameController>().IsGameStarted())
        {
			return;
        }
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
		if(isGrounded && velocity.y<0)
        {
			velocity.y = -2f;
        }
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		Vector3 move = transform.right * x + transform.forward * z;
		controller.Move(move * movementSpeed * Time.deltaTime);
		if(isGrounded && controller.velocity.magnitude>2f && !GetComponent<AudioSource>().isPlaying)
        {
			GetComponent<AudioSource>().volume = Random.Range(0.8f, 1);
			GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
			GetComponent<AudioSource>().Play();

		}
		if(Input.GetButtonDown("Jump") && isGrounded)
        {
			jump = true;
        }
		velocity.y += gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);
	}
	void FixedUpdate()
    {
        if (jump)
        {
			Jump();
			jump = false;
        }
    }
	void Jump()
    {
		velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
	}
}
