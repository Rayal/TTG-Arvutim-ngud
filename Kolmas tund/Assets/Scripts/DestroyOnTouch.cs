﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Destroyable"))
			Destroy (other.gameObject);
	}
}
