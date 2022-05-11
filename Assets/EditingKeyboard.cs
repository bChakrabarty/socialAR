using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditingKeyboard : MonoBehaviour
{
	public static TouchScreenKeyboard keyboard;
	public static Text EditingObject;
	public Text TargetText;

	public void OpenSystemKeyboard()
	{
		keyboard = TouchScreenKeyboard.Open(TargetText.text, TouchScreenKeyboardType.Default, false, false, false, false);
		keyboard.text = TargetText.text;
		EditingObject = TargetText;
	}

	private void Update()
	{
		if (keyboard != null && EditingObject == TargetText)
		{
			string keyboardText = keyboard.text;
			EditingObject.text = keyboardText;
		}
	}
}
