using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue()
	{
		Speech.AddDialogue("0", "Hello, traveller, Welcome to our planet", "1");
		Speech.AddDialogue("1", "We need your help!", "2");
		Speech.AddDialogue("2", "Please save our planet - find tower", "3");
		Speech.AddDialogue("3", "Find powerup to jump higher before going to next island","4");
		Speech.AddDialogue("4", "If you already have Powerup  then just go to next island");

	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other )
	{
        if (Abilities.doubleJumpEnabled)
        {
			Speech.SetDialogue("4");
        }
        else
        {
			Speech.SetDialogue("0");
		}
		
	}
}