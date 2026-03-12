using UnityEngine;
using TMPro; 

public class UIUpdater : MonoBehaviour
{
    [Header("Textos de la Interfaz")]
    [SerializeField] private TextMeshProUGUI textoMonedas;
    [SerializeField] private TextMeshProUGUI textoVidas; 

    private void Start()
    {
        GameManager.Instance.OnCoinsChanged += ActualizarTextoMonedas;
        GameManager.Instance.OnLivesChanged += ActualizarTextoVidas;

        ActualizarTextoMonedas(0); 
        ActualizarTextoVidas(3); 
    }

    private void OnDestroy() 
    {
        
        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnCoinsChanged -= ActualizarTextoMonedas;
            GameManager.Instance.OnLivesChanged -= ActualizarTextoVidas;
        }
    }

    private void ActualizarTextoMonedas(int cantidadMonedas)
    {
        textoMonedas.text = "Monedas: " + cantidadMonedas;
    }

    private void ActualizarTextoVidas(int vidasRestantes)
    {
        textoVidas.text = "Vidas: " + vidasRestantes;
    }
}
