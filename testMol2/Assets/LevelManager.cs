using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public MolT1 MolTest1;


	public void loadMainLevel(){
		SceneManager.LoadScene ("SceneMain");
		MolTest1 = new MolT1 ();
		string testStr = "HALLO!!!";
		MolTest1.readData (testStr);
		/*if (MolTest1) {
			MolTest1.readData (testStr);
		}*/
	}

	public void loadAuthorLevel(){
		SceneManager.LoadScene ("SceneAuthors");

	}
	public void loadEntryLevel(){
		SceneManager.LoadScene ("SceneOne");
	}
}
