using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float thrust;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.Space )){
			rb.AddForce(0,thrust,0 , ForceMode.Impulse);
		}
	}
}
