﻿using UnityEngine;
using System.Collections;

/*
 * custom mouse cursors
 * adpated from:
 * http://docs.unity3d.com/ScriptReference/Cursor.SetCursor.html
 */
public class CustomCursorPointer : MonoBehaviour
{
	public Texture2D cursorTexture2D;

	private CursorMode cursorMode = CursorMode.Auto;
	private Vector2 hotSpot = Vector2.zero;

	//------------------------------------
	// when mouse over, change to custom cursor
	public void OnMouseEnter()
	{
		SetCustomCursor(cursorTexture2D);
	}

	//------------------------------------
	// when mouse moves away, revert back to system cursor
	public void OnMouseExit()
	{
		SetCustomCursor(null);
	}
	
	//------------------------------------
	// change the mouse cursor
	// if 'curText' null, then will revert to default cursor
	private void SetCustomCursor(Texture2D curText)
	{
		Cursor.SetCursor(curText, hotSpot, cursorMode);
	}
}
