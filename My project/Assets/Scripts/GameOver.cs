using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private GameObject player;
    private PlayerController scriptPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        scriptPlayer = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptPlayer.vida <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
