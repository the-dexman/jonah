using UnityEngine;


public class Projectile : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float lifeTime;
    Rigidbody2D rigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.linearVelocity = transform.TransformVector(Vector2.right * speed);
    }
}
