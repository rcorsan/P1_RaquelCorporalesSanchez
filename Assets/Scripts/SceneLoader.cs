using UnityEngine;
using UnityEngine.SceneManagement;  

public class SceneLoader : MonoBehaviour
{
    public void CargarNivel()
    {
        SceneManager.LoadScene("scene2"); 
    }
    public void CargarMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
