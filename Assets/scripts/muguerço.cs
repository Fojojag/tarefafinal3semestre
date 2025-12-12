using UnityEngine;
using System.Collections;
public class muguerço : wrapper
{
    SpriteRenderer rend;
    Color c;
    [SerializeField] SpriteRenderer spriteRenderer;

    public muguerçoAttack ataque;
    public bool isAttacking = false;
    public GameObject target1;
    public GameObject target2;
    public bool IsFacingRight;
    public bool canAttack = false;
   
    private float timer;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    InitializeLogic();

    }
    public override void InitializeLogic()
    {
        Enemy = new morcego();
    }

    public class morcego: inimigosmain
{
     public GameObject trigger;
        public override void TakeDamage(int damageAmount)
    {
        base.TakeDamage(damageAmount - 1);
    }
    public override void ded()
    {
        base.ded();
    }
}

    // Update is called once per frame
    void Update()
    {




        if (canAttack && !isAttacking && !IsFacingRight && timer <= 0)
        {
            ataque.enabled = true;
            ataque.InitializePulo(target1);
            isAttacking = true;
            timer = 2;

        }
        if (canAttack && !isAttacking && IsFacingRight && timer <= 0)
        {
            ataque.enabled = true;
            ataque.InitializePulo(target2);
            isAttacking = true;
            timer = 2;

        }
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
        public void flip()
    {
        transform.Rotate(0f, 180f, 0f);
        IsFacingRight = !IsFacingRight;
    }



}
