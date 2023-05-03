using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
	[Tooltip("The gameobject the player should teleport too.")]
    public Transform teleportToLocation;

    public void TeleportPlayer(CharacterController player)
    {
        //CharacterController cc = GetComponent<Collider>().GetComponent<CharacterController>();

        player.enabled = false;
        player.transform.position = teleportToLocation.position;
        player.enabled = true;

        ActionTrigger actionTrigger =gameObject.GetComponent<ActionTrigger>();
        actionTrigger.promptTextBox.text = "";
        actionTrigger.inTrigger = false;
    }
}
