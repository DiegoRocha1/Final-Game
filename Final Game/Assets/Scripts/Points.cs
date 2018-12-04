using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

	public static int pointVal = 0;
	public static int count;

	private TextMeshProUGUI points;
	
	// Use this for initialization
	void Start ()
	{
        pointVal = 0;
		points = GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		points.text = "Hits: " + pointVal;
	}
}
