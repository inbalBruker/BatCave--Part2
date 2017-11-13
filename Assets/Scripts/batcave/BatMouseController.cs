using System;
using BatCave;
using UnityEngine;
using UnityEngine.EventSystems;
using Infra.Gameplay.UI;

namespace AssemblyCSharp
{
	[CreateAssetMenu(menuName = "Bat Controller/Mouse")]
	public class BatMouseController : BatController
	{
		private bool MousePressed;
		protected void OnEnable() {

			GameInputCapture.OnTouchDown += OnTouchDown;
			GameInputCapture.OnTouchUp += OnTouchUp;

		}

		protected void OnDisable() {
			GameInputCapture.OnTouchDown -= OnTouchDown;
			GameInputCapture.OnTouchUp -= OnTouchUp;

		}

		public override bool WantsToFlyUp(){
			return MousePressed;
		}

		private void OnTouchDown(PointerEventData e) {
			MousePressed = true;
		}

		private void OnTouchUp(PointerEventData e) {
			MousePressed = false;
		}
	}
}

