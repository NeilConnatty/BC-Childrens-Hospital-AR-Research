using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class VirtualButtonEventHandlerTest : MonoBehaviour, IVirtualButtonEventHandler
{

	public GameObject[] _uiPanels;

	void Start ()
	{
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i=0; i<vbs.Length; i++) {
			vbs[i].RegisterEventHandler (this);
		}

		disableAllPanels ();
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
	{
		if (!isValid ()) return;

		disableAllPanels ();

		switch (vb.VirtualButtonName) {
			case "red" :
				_uiPanels[0].SetActive (true);
				break;

			case "blue" :
				_uiPanels[1].SetActive (true);
				break;

			case "yellow" :
				_uiPanels[2].SetActive (true);
				break;

			case "green" :
				_uiPanels[3].SetActive (true);
				break;
		}
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{
		// TODO
	}

	private bool isValid ()
	{
		// check that _uiPanels has been set properly
		return _uiPanels != null && _uiPanels.Length == 4;
	}

	private void disableAllPanels ()
	{
		for (int i=0; i<_uiPanels.Length; i++) {
			_uiPanels[i].SetActive (false);
		}
	}
}
