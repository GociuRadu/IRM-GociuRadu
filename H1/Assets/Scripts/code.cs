using UnityEngine;

public class CactusAI : MonoBehaviour
{
    public Transform otherCactus;   
    public float attackDistance = 0.25f; 
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (otherCactus == null) return;

        float distance = Vector3.Distance(transform.position, otherCactus.position);

        bool shouldAttack = distance < attackDistance;

        animator.SetBool("isAttack", shouldAttack);
    }
}
