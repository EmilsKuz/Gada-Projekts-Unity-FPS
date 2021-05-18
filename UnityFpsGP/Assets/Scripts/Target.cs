using UnityEngine;

public class Target : MonoBehaviour
{


    public float health = 10f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f) 
        {
            Die();
        }

        void Die()
        {
            TargetsLeft.targetCount -= 1;
            Destroy(gameObject);
            
        }
    }
}
