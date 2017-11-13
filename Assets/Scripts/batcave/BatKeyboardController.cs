using System;
using BatCave;
using UnityEngine;
using UnityEngine.EventSystems;
using Infra.Gameplay.UI;

namespace AssemblyCSharp
{
	[CreateAssetMenu(menuName = "Bat Controller/Keyboard")]
	public class BatKeyboardController : BatController
	{
		private bool flyUp;
		public override bool WantsToFlyUp(){
			if (Input.GetKeyDown(KeyCode.Space)) {
				flyUp =  true;
			} else if (Input.GetKeyUp(KeyCode.Space)) {
				flyUp =  false;
			}
			return flyUp;
		}

	}

}

