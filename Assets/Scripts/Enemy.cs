using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public LayerMask wallLayer;
    public LayerMask enemyLayer;
    public EnemySO enemySO;
    public Animator animator;
    public float colliderDistance;
    public Transform transform;
    public BoxCollider2D boxCollider;
    private float attackCooldown;
    private float coolDownTimer;
    public float range;
    public float health;
    public GameObject gameObject;

    void Start()
    {
        this.health = enemySO.health;
        if (enemySO.type == CharacterType.Melee)
            range = 1;
        else
            range = 7;
    }

    // Update is called once per frame
    void Update()
    {
        coolDownTimer += Time.deltaTime;

        if (EnemiesInSight())
        {
            animator.SetBool("Run", false);
            if (coolDownTimer >= enemySO.attackCooldown)
            {
                coolDownTimer = 0;
                if (enemySO.type == CharacterType.Melee)
                    animator.SetTrigger("MeleeAttack");
                else
                    animator.SetTrigger("MagicAttack");
                Damage();
            }
        }
        if (!EnemiesInSight())
            Move();

        if (health <= 0)
            DestroyObject();
    }

    void Move()
    {
        animator.SetBool("Run", true);
        if (enemySO.moveSpeed == MoveSpeed.Fast)
            transform.Translate(-transform.right * 5 * Time.deltaTime);
        else if (enemySO.moveSpeed == MoveSpeed.Normal)
            transform.Translate(-transform.right * 3 * Time.deltaTime);
        else if (enemySO.moveSpeed == MoveSpeed.Slow)
            transform.Translate(-transform.right * 1 * Time.deltaTime);
    }

    private bool EnemiesInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center - transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z),
            0, Vector2.left, 0, enemyLayer);

        if (hit.collider != null)
        {
            if (hit.transform.gameObject.layer.Equals(7))
            {
                gameObject = hit.collider.transform.gameObject;
            }
            if (hit.transform.gameObject.layer.Equals(6))
            {
                gameObject = hit.collider.transform.gameObject;
            }
        }
        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center - transform.right * range * transform.localScale.x * colliderDistance
            , new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }

    private void Damage()
    {
        if(EnemiesInSight())
        {
            if(gameObject != null)
            {
                if (gameObject.layer.Equals(7))
                    gameObject.transform.Find("UnitRoot").GetComponent<Character>().health -= enemySO.attack;
                if(gameObject.layer.Equals(6))
                    Player.instance.currentHealth -= (int) enemySO.attack;
            }
        }
    }


    public void DestroyObject()
    {
        Destroy(transform.gameObject);
    }
}
