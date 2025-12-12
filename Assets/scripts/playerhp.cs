using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerhp : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float maxhealth;
    public Animator anim;
    //public Image healthbar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxhealth;    
    }

    void Update()
    {
        //healthbar.fillAmount = Mathf.Clamp(maxhealth / health, 0, 1);
        if (health <= 0)
        {
            morreu();
        }

    }

    // Update is called once per frame

 
    public virtual void TakeDamage(int damageAmount)
    {

        health -= damageAmount;

    }

    public virtual void ded()
    {
        anim.SetBool("ded", true);
    }
    void morreu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}