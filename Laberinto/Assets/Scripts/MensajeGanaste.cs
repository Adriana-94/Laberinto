using UnityEngine;
using UnityEngine.UI;


public class MensajeGanaste : MonoBehaviour
{

    public GameObject textoGanaste;

    private void Start()
    {
        if (textoGanaste != null)
            textoGanaste.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Jugador llegó a la meta!");
            if (textoGanaste != null)
            {
                textoGanaste.SetActive(true);
                Debug.Log("Texto activado correctamente.");
            }
            else
            {
                Debug.LogError("Error: textoGanaste no está asignado en el Inspector.");
            }
            Invoke("ReiniciarJuego", 10f);
        }
    }
    void ReiniciarJuego()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}

