/*===============================================================================
Copyright (c) 2016 PTC Inc. All Rights Reserved.

Confidential and Proprietary - Protected under copyright and other laws.
Vuforia is a trademark of PTC Inc., registered in the United States and other
countries.
===============================================================================*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelShowHide : MonoBehaviour
{
    //public Animator _animator;
    public GameObject _panel;
    public Text _title;
    public Text _id;
    public UnityEngine.UI.Image _image;

    void Start ()
    {
        _panel.SetActive (false);
    }

	public void Hide()
    {
        //_animator.SetTrigger("HidePanel");
        _panel.SetActive (false);
    }

    public void Show(string title, string id, Sprite image)
    {
        //_animator.ResetTrigger("HidePanel");
        _title.text = title;
        _id.text = id;
        _image.sprite = image;
        _image.preserveAspect = true;
        _panel.SetActive (true);
        /*
        if (!_animator.GetCurrentAnimatorStateInfo(0).IsName("ShowAnim"))
        {
            _animator.SetTrigger("ShowPanel");
        }
        */
    }

    public void ResetShowTrigger()
    {
        //_animator.ResetTrigger("ShowPanel");
    }
}
