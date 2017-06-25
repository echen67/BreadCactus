using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : PlayerMovement {

	void Start() {
		base.setRaycastLength(2.3f);
		setKeys (KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S);
	}
}
