using UnityEngine;
using TMPro;
public class UImoeda : MonoBehaviour
{
    private TextMeshProUGUI texto;
    private int coinCount = 0;


    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();

        UpdateDisplay();
    }

    void Update()
    {
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {

        texto.text = "Moedas: " + coinCount.ToString();

    }
        public void AddCoin()
    {
        coinCount += 1;

    }
}