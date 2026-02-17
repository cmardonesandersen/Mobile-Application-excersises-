using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Player : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;

    public DodgerAttributes attributes;

    public TextMeshProUGUI healthText;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        attributes = new DodgerAttributes(100, 100, 0);

        healthText.text = "Health = " + attributes.currHealth.ToString();
          
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * moveSpeed);
            }
            else
            {
                rb.AddForce(Vector2.right * moveSpeed);
            }
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Crate")
        {
            attributes.ChangeHealth(-20);
            healthText.text = "Health = " + attributes.currHealth.ToString();
            

            if (attributes.currHealth <= 0)
            {
                SceneManager.LoadScene("Game");
                Debug.Log("RESET");
            }

            Destroy(collision.gameObject);
        }
    }
}