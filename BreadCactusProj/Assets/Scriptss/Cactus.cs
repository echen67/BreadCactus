using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : PlayerMovement {

	void Start() {
		base.setRaycastLength(3.2f);
		setKeys (KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.UpArrow, KeyCode.DownArrow);
	}
}
