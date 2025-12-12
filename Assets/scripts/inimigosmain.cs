using UnityEngine;

public class inimigosmain : MonoBehaviour
{
    public int health = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0)
        {
            ded();
        }
    }
        void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "limao")          
        {
            Destroy(collision.gameObject);
            TakeDamage(3);
        }
        
        if(collision.gameObject.tag == "chargeshot")          
        {
            Destroy(collision.gameObject);
            TakeDamage(10);
        }
        
    }
    public virtual void TakeDamage(int damageAmount)
    {

        health -= damageAmount;

    }

    public virtual void ded()
    {
        Destroy(gameObject);
    }
}
