using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class BalloonHandContact : MonoBehaviour {

	public float thrust;
	public Rigidbody rb;
	public GameObject hand;
	public GameObject balloon;

	public GameObject duplic;
	public GameObject floor;
	
	public AudioSource hit;
	public AudioSource pop;
	public AudioSource end;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		AudioSource audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame

	void Update()
	{	
		if (Count.pointVal == 0)
		{
			// the retry scene and play ending sound
			Count.points.text = "GAME OVER";
		}
		
			
		if (Mathf.Abs(floor.transform.position[1] - balloon.transform.position[1]) <= 1.5)
		{
			pop.Play();
			Destroy(balloon);
			Count.pointVal -= 1;

			if (Count.pointVal == 0)
			{
				// the retry scene and play ending sound
				Count.points.text = "GAME OVER";
			}
		}

//		if (dupCheck)
//		{
//			if (Count.pointVal == 0)
//			{
//				Count.points.text = "GAME OVER";
//			}
//			
//			if (Mathf.Abs(floor.transform.position[1] - duplic.transform.position[1]) <= 1.1)
//			{
//				Destroy(balloon);
//				Count.pointVal -= 1;
//
//				if (Count.pointVal == 0)
//				{
//				Count.points.text = "GAME OVER";
//				}
//			}
//		}
		
		
		if (Mathf.Abs(hand.transform.position[1] - balloon.transform.position[1]) <= 2.5 && 
		    (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
		{
			hit.Play();
			rb.AddForce(0, thrust, 0, ForceMode.Impulse);
			Points.pointVal += 1;
			Points.count += 1;

			if (Points.count == 5)
			{
				Instantiate(duplic, new Vector3(balloon.transform.position[0], balloon.transform.position[1], balloon.transform.position[2] ), Quaternion.identity);
				rb.AddForce(0, thrust, 0, ForceMode.Impulse);
				Points.count = 0;
				Count.pointVal += 1;
			}
		}
	}
//	private void OnCollisionEnter(Collision other)
//	{
//		rb.AddForce(0, thrust, 0, ForceMode.Impulse);
//	}
}
