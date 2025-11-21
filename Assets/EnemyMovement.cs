using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform ledgeCheck;
    Rigidbody2D rigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.linearVelocity = new Vector2(transform.TransformVector(Vector3.right * speed).x, rigidBody.linearVelocity.y);
        if (!Physics2D.Raycast(ledgeCheck.position, Vector2.down, 1f))
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<Health>() != null)
            {
                collision.gameObject.GetComponent<Health>().TakeDamage(1f);
            }
            
        }
    }
}
