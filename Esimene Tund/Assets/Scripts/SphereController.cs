using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
	Rigidbody rb;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float vert = Input.GetAxis ("Vertical");
		float hori = Input.GetAxis ("Horizontal");
		rb.AddForce (hori, 0.0f, vert);
	}
}
