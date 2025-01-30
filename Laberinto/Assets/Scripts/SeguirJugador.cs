using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform player;  // Referencia al jugador
    public Vector3 offset = new Vector3(3, 52, -39);  // Posici�n isom�trica
    public float smoothSpeed = 5f;  // Velocidad de suavizado

    void LateUpdate()
    {
        if (player != null)
        {
            // Calcular la posici�n deseada de la c�mara
            Vector3 desiredPosition = player.position + offset;

            // Suavizar el movimiento de la c�mara
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            // Opcional: Mantener la rotaci�n fija en vista isom�trica
            transform.rotation = Quaternion.Euler(42.8f, -1.2f, -1.26f);
        }
    }
}
