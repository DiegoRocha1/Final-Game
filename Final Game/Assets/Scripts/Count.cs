using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{

	public static int pointVal = 1;
	public static int count;

	public static TextMeshProUGUI points;
	
	// Use this for initialization
	void Start ()
	{
        pointVal = 1;
		points = GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (pointVal != 0)
		{
			points.text = "Balloons: " + pointVal;
		}
	}
}
