using UnityEngine;

public class MovementController : MonoBehaviour
{
   
	public bool isGrounded;
	public float vertSpeed;
	public float horzSpeed;
	
	Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	
	void OnCollisionStay() {
		isGrounded = true;
	}
	
	void Update() {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * horzSpeed;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * vertSpeed;

		transform.Translate(x, 0, 0);
		transform.Translate(0, 0, z);
		
		//if (Input.GetKeyDown ("space")){
		//	transform.Translate(Vector3.up * Time.deltaTime * 30, Space.World);
		//}	
	}
}
