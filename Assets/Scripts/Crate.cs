using UnityEngine;

public class Crate : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.y < -6f)

                Destroy(gameObject);


    }
}
