using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameGUI : MonoBehaviour {

	private GameObject inventoryPanel;
	private GameObject pausePanel;
	private GameObject radioPanel;

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () 
	{
		inventoryPanel = GameObject.Find ("InventoryPanel");
		pausePanel = GameObject.Find ("PausePanel");
		radioPanel = GameObject.Find ("RadioPanel");
		inventoryPanel.SetActive (false);
		pausePanel.SetActive (false);
		radioPanel.SetActive (false);
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update()
	{
		// update keycodes from the ControlScheme here - to perform the methods stated below
	}

	/// <summary>
	/// Raises the pause button click event.
	/// </summary>
	public void OnPauseClick() 
	{
		pausePanel.SetActive (true);
	}

	/// <summary>
	/// Raises the inventory button click event.
	/// </summary>
	public void OnInventoryClick()
	{
		inventoryPanel.SetActive (true);
	}

	/// <summary>
	/// Raises the radio button click event.
	/// </summary>
	public void OnRadioClick()
	{
		radioPanel.SetActive (true);
	}

	/// <summary>
	/// Raises the resume button click event.
	/// </summary>
	public void OnResumeClick()
	{
		pausePanel.SetActive (false);
		inventoryPanel.SetActive (false);
		radioPanel.SetActive (false);
		// enable player?/set Raycast Target to true again?
	}

}
