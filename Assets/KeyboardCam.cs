using UnityEngine;
using System.Collections;

public class KeyboardCam : MonoBehaviour {


	float moveSpeed = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MoveHorizontal(Input.GetAxis ("Horizontal"));
		MoveVertical(Input.GetAxis ("Vertical"));

	}

	void MoveHorizontal(float direction) {
		transform.Translate (Vector3.right * direction * moveSpeed, Space.World);
	}

	void MoveVertical(float direction) {
		transform.Translate (Vector3.forward * direction * moveSpeed, Space.World);
	}
}
