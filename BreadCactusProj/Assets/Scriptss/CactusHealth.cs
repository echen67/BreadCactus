using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusHealth : PlayerHealth {

	void Start() {
		base.setHealthBar(GameObject.FindGameObjectWithTag("CactusHealth"));
	}
}
