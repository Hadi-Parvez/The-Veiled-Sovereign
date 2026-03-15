using UnityEngine;

public class MovementSwitch : MonoBehaviour
{
    public playerController.MovementMode zoneMode;

    private void OnTriggerEnter2D(Collider2D other)
    {
        playerController player = other.GetComponent<playerController>();

        if (player != null)
        {
            player.movementMode = zoneMode;
        }
    }
}