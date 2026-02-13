using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene("Level1");
	}

	public void Options()
	{
		SceneManager.LoadScene("Options");
	}

	public void BackMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
