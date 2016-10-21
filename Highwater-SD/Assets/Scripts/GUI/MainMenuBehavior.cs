using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuGUI : MonoBehaviour {

	private GameObject settingsPanel;
	private GameObject endCreditsPanel;

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start ()
	{
		settingsPanel = GameObject.Find("SettingsPanel");
		endCreditsPanel = GameObject.Find("EndCreditsPanel");
		settingsPanel.SetActive (false);
		endCreditsPanel.SetActive (false);
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update()
	{
		// update keycodes from the ControlScheme here - to perform the methods stated below
	}

	/// <summary>
	/// Raises the settings button click event.
	/// </summary>
	public void OnSettingsClick()
	{
		settingsPanel.SetActive (true);
		endCreditsPanel.SetActive (false);
	}

	/// <summary>
	/// Raises the exit button click event.
	/// </summary>
	public void OnExitClick()
	{
		endCreditsPanel.SetActive (true);
		settingsPanel.SetActive (false);
	}

	/// <summary>
	/// Raises the start button click event.
	/// </summary>
	public void OnStartClick()
	{
		SceneManager.LoadScene ("Game");
	}

	/// <summary>
	/// Raises the back to main button click event.
	/// </summary>
	public void OnBackToMainClick()
	{
		endCreditsPanel.SetActive (false);
		settingsPanel.SetActive (false);
	}
}
