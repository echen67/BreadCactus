using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadHealth : PlayerHealth {

	void Start() {
		base.setHealthBar(GameObject.FindGameObjectWithTag("BreadHealth"));
	}
}
