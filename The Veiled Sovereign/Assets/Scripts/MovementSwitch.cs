using UnityEngine;

public class MovementSwitch : MonoBehaviour
{
    public PlayerMovement.MovementMode zoneMode;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();

        if (player != null)
        {
            player.movementMode = zoneMode;
        }
    }
}