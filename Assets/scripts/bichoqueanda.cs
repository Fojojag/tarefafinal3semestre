using UnityEngine;
using System.Collections;
public class bichoqueanda : wrapper
{
    SpriteRenderer rend;
    Color c;
    [SerializeField] SpriteRenderer spriteRenderer;

    [SerializeField] public float speed;
    [SerializeField] private Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    InitializeLogic();

    }
    public override void InitializeLogic()
    {
        Enemy = new Anda();
    }

    public class Anda: inimigosmain
{

        public override void TakeDamage(int damageAmount)
    {
        base.TakeDamage(damageAmount - 2);
    }
    public override void ded()
    {
        base.ded();
    }
}

    // Update is called once per frame
    void Update()
    {


         rb.linearVelocity = Vector2.right * speed; 


}
}