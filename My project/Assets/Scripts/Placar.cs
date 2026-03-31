using UnityEngine;
using TMPro;

public class Placar : MonoBehaviour
{
    public TMP_Text vidaTexto;
    public TMP_Text pontoTexto;

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
        vidaTexto.text = "VIDAS: " + scriptPlayer.vida.ToString();
        pontoTexto.text = "PONTOS: " + scriptPlayer.ponto.ToString();
    }
}
