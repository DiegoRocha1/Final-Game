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

	public Text balloonCount;
	public GameObject duplic;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame

	void Update()
	{
//		Debug.Log(hand.transform.position);
//		Debug.Log(balloon.transform.position);
		
		if (Mathf.Abs(hand.transform.position[1] - balloon.transform.position[1]) <= 1.5 && 
		    (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
		{
			rb.AddForce(0, thrust, 0, ForceMode.Impulse);
			Points.pointVal += 1;

			if (Points.pointVal == 3)
			{
				Instantiate(duplic, new Vector3(balloon.transform.position[0], balloon.transform.position[1], balloon.transform.position[2] ), Quaternion.identity);
				rb.AddForce(0, thrust, 0, ForceMode.Impulse);
			}
		}

	}
//	private void OnCollisionEnter(Collision other)
//	{
//		rb.AddForce(0, thrust, 0, ForceMode.Impulse);
//	}
}
