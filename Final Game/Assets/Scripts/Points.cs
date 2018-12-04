using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

	public static int pointVal = 0;

	private TextMeshProUGUI points; 
	
	// Use this for initialization
	void Start ()
	{
		points = GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		points.text = "Hits: " + pointVal;
	}
}
