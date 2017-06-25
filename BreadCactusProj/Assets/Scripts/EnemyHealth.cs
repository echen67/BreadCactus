using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int currentHealth = 100;
    public int maxHealth = 100;

    public int damage = -10;

    public void TakeDamage(int damage)
    {
        currentHealth += damage;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            PlayerHealth playerScript = coll.GetComponent<PlayerHealth>();
            playerScript.UpdateHealth(damage);
        }
    }
}
