using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    
    public Transform ball;

	// LateUpdate is the last method called, camera update suggested here
	void LateUpdate () {
        if (ball != null)
        {
            if (ball.position.y > transform.position.y && GameController.isPlaying)
            {
                Vector3 currentPosition = transform.position;
                currentPosition.y = ball.position.y;
                transform.position = currentPosition;
            }
        }
	}
}
