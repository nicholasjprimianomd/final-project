using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goto : MonoBehaviour
{

	public void loadStart ()
	{
		SceneManager.LoadScene ("Start");
	}

	public void loadInstruction ()
	{
		SceneManager.LoadScene ("Instructions");
	}

	public void loadCredits ()
	{
		SceneManager.LoadScene ("Credits");
	}
}


// this is a comment to say that I am fixing this!
// this is a second comment to say that I am fixing this!