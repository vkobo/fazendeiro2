using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject pauseMenu;

    public GameObject pauseButtons;
    public GameObject confirmacaoButtons;

    public InputActionAsset InputActions;

    private InputAction pauseAction;
    private void Awake()
    {
        pauseAction = InputSystem.actions.FindAction("Pause");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseAction.WasPressedThisFrame())
        {
            Pausar();
        }
    }

    public void Pausar()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }

        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }

    public void SairConfirmacao()
    {
        pauseButtons.SetActive(false);
        confirmacaoButtons.SetActive(true);
    }

    public void Voltar()
    {
        pauseButtons.SetActive(true);
        confirmacaoButtons.SetActive(false);
    }

    public void Sair()
    {
        Time.timeScale = 1;
        pauseButtons.SetActive(true);
        confirmacaoButtons.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
