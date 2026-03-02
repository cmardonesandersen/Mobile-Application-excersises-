using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{

    public float gravityScale = 1f;

    protected Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale;
    }

    void Update()
    {

        if (transform.position.y < -6f)

            Destroy(gameObject);


    }
}

