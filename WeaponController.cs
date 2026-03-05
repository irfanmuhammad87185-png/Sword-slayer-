using UnityEngine;

public class WeaponController : MonoBehaviour {
    public float attackCooldown = 1.0f; // Time in seconds before the weapon can be used again
    private float lastAttackTime = 0;

    public void Attack() {
        if (Time.time >= lastAttackTime + attackCooldown) {
            // Perform attack action
            Debug.Log("Weapon attacked!");
            lastAttackTime = Time.time; // Update the last attack time
        } else {
            Debug.Log("Weapon is on cooldown!");
        }
    }
}