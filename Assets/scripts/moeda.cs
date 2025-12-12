using UnityEngine;

public class moeda : MonoBehaviour
{
    private UImoeda UI;
    void Start()
    {
        GameObject texto = GameObject.FindGameObjectWithTag("texto");
        UI = texto.GetComponent<UImoeda>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Player")          
            {
                {
                    UI.AddCoin();
                    Destroy(gameObject);
                }
            }
        }


}