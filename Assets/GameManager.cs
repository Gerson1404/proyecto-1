using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public int totalPickups;
	public Text winText;
	public Text timerText;

	public float tiempo = 120f;

	void Start()
	{
		winText.gameObject.SetActive(false);
	}

	void Update()
	{
		tiempo -= Time.deltaTime;
		timerText.text = "Tiempo: " + Mathf.Round(tiempo);

		if(tiempo <= 120)
		{
			SceneManager.LoadScene("MainMenu");
		}
	}

	public void PickupCollected()
	{
		totalPickups--;

		if(totalPickups <= 4)
		{
			winText.gameObject.SetActive(true);
			StartCoroutine(BackMenu());
		}
	}

	IEnumerator BackMenu()
	{
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene("MainMenu");
	}
}
