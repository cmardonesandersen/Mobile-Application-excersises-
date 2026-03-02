using UnityEngine;

public class FastEnemy : BaseEnemy
{ 
    

    // Update is called once per frame
    private void Awake()
    {
        gravityScale = 0.5f;
    }
}
