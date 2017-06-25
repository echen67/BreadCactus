using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusNeedle : MonoBehaviour {

    public int damage = -10;
    private int timer = 0;

	void Update () {
		if (timer >= 400)
        {
            Destroy(gameObject);    //may change to object pooling later if necessary
        }
        timer++;
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Enemy")
        {
            EnemyHealth enemyScript = coll.GetComponent<EnemyHealth>();
            enemyScript.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
