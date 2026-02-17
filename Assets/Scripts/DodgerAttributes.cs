using JetBrains.Annotations;
using UnityEngine;

public class DodgerAttributes


{
    public int currHealth;
    public int maxHealth;
    public int currScore;



    public DodgerAttributes(int currHealth, int maxHealth, int currScore)
    {

        this.currHealth = currHealth;
        this.maxHealth = maxHealth;
        this.currScore = currScore;

    }

    public void ChangeHealth (int chHealth)
     {
        currHealth += chHealth;

     }
}
