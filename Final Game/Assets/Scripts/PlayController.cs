﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayController : MonoBehaviour
{

	public GameObject hand;
	public GameObject balloon;
	public AnimationClip clip;
	private Animation anim;
	
	public float speed;
	
	// Use this for initialization
	void Start () {
		anim = hand.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			anim.clip = clip;
			
			anim.Play();
		}
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Start Menu");
        }
		//(Input.GetKeyDown(KeyCode.Space))
//		{
//			//while (hand.transform.rotation.x < 50)
//			//{
//				
//			//}
//			//hand.transform.position = new Vector3(hand.transform.position.x, 5, hand.transform.position.z);
//			//while (hand.transform.eulerAngles.x < 50f)
//			//{
//			//	float deg = hand.transform.eulerAngles.x;
//			//	hand.transform.eulerAngles = new Vector3(deg+1, hand.transform.eulerAngles.y, hand.transform.eulerAngles.z);
//				//hand.transform.Rotate(Vector3.right, speed * Time.deltaTime);
//			//}
//		}
	}

	void OnCollisionEnter(Collision c)
	{
//		float force = 200;
//		if (c.gameObject == balloon)
//		{
//			Vector3 dir = c.contacts[0].point - transform.position;
//			// We then get the opposite (-Vector3) and normalize it
//			dir = dir.normalized;
//			// And finally we add force in the direction of dir and multiply it by force. 
//			// This will push back the player
//			GetComponent<Rigidbody>().AddForce(dir*force);
//		}
	}
}
