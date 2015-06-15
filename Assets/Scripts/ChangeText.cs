using UnityEngine;
using System.Collections;

public class ChangeText : MonoBehaviour 
{
	GUIText racename;
	public int racenum = 1;
	
	void Start()
	{
		racename = gameObject.GetComponent<GUIText>();
		if (racename == null) 
		{
			Debug.LogError("GUIText component not found");
		}
		racename.text = "Human";
	}
	
	void Update()
	{
		if (racenum == 1 && racenum != null)
		{
			racename = gameObject.GetComponent<GUIText>();
			racename.text = "Human";
		}
		if (racenum == 2 && racenum != null)
		{
			racename = gameObject.GetComponent<GUIText>();
			racename.text = "Elf";
		}
	}
}
