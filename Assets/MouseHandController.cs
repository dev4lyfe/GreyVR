using UnityEngine;
using System.Collections;

public class MouseHandController : MonoBehaviour {

	float moveSpeed = .4f;
	Vector3 startPos;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		MoveHorizontal(Input.GetAxis("Mouse X"));
		MoveVertical(Input.GetAxis("Mouse Y"));

	}
	void MoveHorizontal(float direction) {
		
		transform.Translate (Vector3.right * direction * moveSpeed, Space.World);
	}

	void MoveVertical(float direction) {
		transform.Translate (Vector3.forward * direction * moveSpeed, Space.World);
	}

	bool CheckHorizontalBounds(float direction) {
		return true;

	}

	bool CheckVerticalBounds(float direction) {
		return true;


	}
}
