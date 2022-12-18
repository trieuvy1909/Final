using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private AudioSource cut;
    [SerializeField] private Animator animator;
    [SerializeField] Transform attackPoint;
    private float attackRange;
    [SerializeField] private LayerMask enemyLayers;
    private int attackDamage;
    void Awake()
    {
        cut = GetComponent<AudioSource>();
        attackDamage = 40;
        attackRange = 1f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            cut.Play();
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);

        }
    }
    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
