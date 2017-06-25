using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusNeedle : MonoBehaviour {

    private int timer = 0;

	void Update () {
		if (timer >= 400)
        {
            Destroy(gameObject);    //may change to object pooling later if necessary
        }
        timer++;
	}
}
