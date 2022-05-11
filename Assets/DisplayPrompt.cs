using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPrompt : MonoBehaviour
{
	[SerializeField]
	private GameObject prefab;
	public void Popup()
	{
		DialogResult result = new DialogResult();
		Dialog.Open(prefab, result);
	}
}
