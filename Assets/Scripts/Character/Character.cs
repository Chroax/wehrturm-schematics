using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public LayerMask wallLayer;
    public LayerMask enemyLayer;
    public CharacterDetailSO characterDetailSO;
    public Animator animator;
    public float colliderDistance;
    public Transform transform;
    public BoxCollider2D boxCollider;
    private float attackCooldown;
    private float coolDownTimer;
    public float range;
    public float health;

    void Start()
    {
        this.health = characterDetailSO.health;
        if(characterDetailSO.attackSpeed == AttackSpeed.Slow)
            attackCooldown = 5;
        else if (characterDetailSO.attackSpeed == AttackSpeed.Normal)
            attackCooldown = 3;
        else if (characterDetailSO.attackSpeed == AttackSpeed.Fast)
            attackCooldown = 1;
        if (characterDetailSO.type == CharacterType.Melee)
            range = 1;
        else
            range = 7;
    }

    // Update is called once per frame
    void Update()
    {
        coolDownTimer += Time.deltaTime;

        if(EnemiesInSight())
        {
            animator.SetBool("Run", false);
            if (coolDownTimer >= attackCooldown)
            {
                coolDownTimer = 0;
                if (characterDetailSO.type == CharacterType.Melee)
                    animator.SetTrigger("MeleeAttack");
                else
                    animator.SetTrigger("MagicAttack");
            }
        }
        if (!OnWall() && !EnemiesInSight())
            Move();

        if (health == 0)
            Death();
    }

    void Move()
    {
        animator.SetBool("Run", true);
        if (characterDetailSO.moveSpeed == MoveSpeed.Fast)
            transform.Translate(transform.right * 5 * Time.deltaTime);
        else if (characterDetailSO.moveSpeed == MoveSpeed.Normal)
            transform.Translate(transform.right * 3 * Time.deltaTime);
        else if (characterDetailSO.moveSpeed == MoveSpeed.Slow)
            transform.Translate(transform.right * 1 * Time.deltaTime);
    }

    private bool OnWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z),
            0, Vector2.left, 0, wallLayer);
        return raycastHit.collider != null;
    }

    private bool EnemiesInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z),
            0, Vector2.left, 0, wallLayer);
        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance
            , new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }

    private void Damage()
    {
        if (EnemiesInSight())
        {
            
        }
    }

    private void Death()
    {
        animator.SetTrigger("Death");
    }

    public void DestroyObject()
    {
        Destroy(transform.gameObject);
    }
}
