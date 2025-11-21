using UnityEngine;
using UnityEngine.InputSystem;
public class Shoot : MonoBehaviour
{
    [SerializeField] float shootCooldown;
    float shootTimer;
    [SerializeField] GameObject projectile;
    [SerializeField] Transform projetileSpawnPoint;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }
    }

    public void Attack(InputAction.CallbackContext input)
    {
        if (shootTimer <= 0 && input.started)
        {
            Instantiate(projectile, projetileSpawnPoint.position, projetileSpawnPoint.rotation);
            shootTimer = shootCooldown;
            animator.SetTrigger("shoot");
        }
        
        
    }
}
