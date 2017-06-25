using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusAttack : MonoBehaviour {

    public GameObject needle;   //set in inspector
    public float shootForce;

	void Update () {
        NeedleAttack();
	}

    void NeedleAttack()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            GameObject needleinstance = Instantiate(needle, gameObject.transform, false) as GameObject;
            needleinstance.transform.position = gameObject.transform.position;
            needleinstance.transform.SetParent(null);
            Rigidbody2D needleBody = needleinstance.GetComponent<Rigidbody2D>();

            Cactus cactusScript = GetComponent<Cactus>();
            bool dir = cactusScript.getCurrentDirection();
            Vector2 vec = dir ? Vector2.right : Vector2.left;
            needleBody.AddForce(vec * shootForce, ForceMode2D.Impulse);
        }
    }
}
