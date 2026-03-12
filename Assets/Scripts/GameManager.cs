using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } 

    // --- PARTE DE LAS MONEDAS ---
    private int coins = 0; 
    public event Action<int> OnCoinsChanged; 

    // --- PARTE DE LAS VIDAS---
    [SerializeField] private int vidasIniciales = 3; 
    private int lives; 
    public event Action<int> OnLivesChanged; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            lives = vidasIniciales; // Al arrancar, nos ponemos las vidas iniciales
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    // --- MÉTODOS ---
    public void AddCoin()
    {
        coins++; 
        OnCoinsChanged?.Invoke(coins); 
    }

    public void LoseLife()
    {
        lives--; 
        OnLivesChanged?.Invoke(lives); 
        
        if (lives <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }
}
