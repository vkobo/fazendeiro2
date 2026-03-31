using UnityEngine;

public class DanoAnimal : MonoBehaviour
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
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scriptPlayer.vida -= 1;
            Debug.Log("Toma dano");
        }
    }
}
