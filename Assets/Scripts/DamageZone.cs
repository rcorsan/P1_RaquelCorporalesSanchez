using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.LoseLife();

            PlayerController jugador = other.GetComponent<PlayerController>();
            if (jugador != null)
            {
                jugador.Respawn();
            }
        }
    }
}
