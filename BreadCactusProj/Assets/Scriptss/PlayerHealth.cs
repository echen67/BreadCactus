using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerHealth : MonoBehaviour {

	public int currentHealth;
	public int maxHealth;

	private GameObject canvas;
	private GameObject healthBar;
	public GameObject getCanvas() {
		return canvas;
	}
	public void setHealthBar(GameObject input){
		healthBar = input;
	}

	private PlayerMovement playerMovementScript;

	void Awake() {
		canvas = GameObject.FindGameObjectWithTag("Canvas");
	}

	public void UpdateHealth(int change){
		currentHealth += change;
		if (currentHealth <= 0) {
			Debug.Log ("Dead");		//IMPLEMENT PLZ
		}
	}
}
