using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

    public float rotateSpeed = 0.2f;

	void Update () {
        transform.Rotate(0.0f, 0.0f, rotateSpeed * Time.deltaTime * 15);
	}
}
