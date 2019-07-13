using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void CarregarFase1()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void CarregarFase2()
    {
        SceneManager.LoadScene("Menu2");
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
}
