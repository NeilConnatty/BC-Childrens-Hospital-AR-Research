using UnityEngine;
using System.Collections;

namespace Testing
{
	public class InputTestManager : MonoBehaviour {

		public GameObject submitUI;
		public GameObject cancelUI;
		public GameObject menuUI;


		public void ActivateSubmitUI ()
		{
			submitUI.SetActive (true);
		}

		public void ActivateCancelUI ()
		{
			cancelUI.SetActive (true);
		}

		public void ActivateMenuUI ()
		{
			menuUI.SetActive (true);
		}

		void DeactivateAllUI ()
		{
			submitUI.SetActive (false);
			cancelUI.SetActive (false);
			menuUI.SetActive (false);
		}

		// Use this for initialization
		void Start ()
		{
			DeactivateAllUI ();
		}

		// Update is called once per frame
		void Update ()
		{
			if (Input.GetButtonUp ("Submit")) {
				DeactivateAllUI ();
				ActivateSubmitUI ();
			}

			if (Input.GetButtonUp ("Cancel")) {
				DeactivateAllUI ();
				ActivateCancelUI ();
			}

			if (Input.GetButtonUp ("Menu")) {
				DeactivateAllUI ();
				ActivateMenuUI ();
			}
		}

	}
}
