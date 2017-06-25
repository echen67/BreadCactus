using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class PlayerHealth : MonoBehaviour {

	public int currentHealth;
	public int maxHealth;

	private GameObject canvas;
	private GameObject healthBar;
    private PlayerMovement playerMovementScript;

    public GameObject getCanvas() {
		return canvas;
	}

	public void setHealthBar(GameObject input){
		healthBar = input;
	}

	void Awake() {
		canvas = GameObject.FindGameObjectWithTag("Canvas");
	}

    void Update()
    {
        //prob dont need this in update; only here for testing
        UpdateHealthBar();
    }

	public void UpdateHealth(int change){
		currentHealth += change;
		if (currentHealth <= 0) {
			Debug.Log ("Dead");		//IMPLEMENT PLZ
		}
	}

    void UpdateHealthBar()
    {
        float x = (currentHealth * .25f / maxHealth) + 0.25f;
        Image image = healthBar.transform.GetChild(0).gameObject.GetComponent<Image>();
        image.fillAmount = x;
    }
}
