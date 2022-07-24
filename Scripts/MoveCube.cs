﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

	float dirX;
	Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		dirX = Input.GetAxis("Horizontal");
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2(dirX * 5, 0);
	}

}
