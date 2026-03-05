using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2.0f;
    public float health = 100f;
    public float attackDamage = 10f;
    public float attackRange = 1.5f;
    public float attackCooldown = 1.0f;
    private float lastAttackTime = 0f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        MoveTowardsPlayer();
        AttackPlayer();
    }

    void MoveTowardsPlayer()
    {
        if (player != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
    }

    void AttackPlayer()
    {
        if (player != null && Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            if (Time.time >= lastAttackTime + attackCooldown)
            {
                // Attack logic (e.g., reduce player's health)
                Debug.Log("Attacking player for " + attackDamage + " damage");
                lastAttackTime = Time.time;
            }
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }
}