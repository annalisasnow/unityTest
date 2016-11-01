using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using OpenBabel;

public class MolT1{
	public TextAsset csvFile;
	public InputField rollNoInputField;// Reference of rollno input field
	public InputField nameInputField; // Reference of name input filed
	public Text contentArea; // Reference of contentArea where records are displayed

	private char lineSeparator = '\n'; // It defines line seperate character
	private char fieldSeparator = ',';

	public void readData(string strTest){
		Debug.Log (strTest);
		Debug.Log ("The connection between the classes works!!!");
		var fileWithData = System.IO.File.ReadAllText("/Users/ani/Downloads/test1.txt");
		string[] lines = fileWithData.Split(lineSeparator);
		string[] fieldData = lines [0].Trim ().Split (fieldSeparator);

		Debug.Log ("WORKS!!!" + fieldData);

		//string[] records = csvFile.text.Split(lineSeparator);

	}

	public string[] lines;
	//string line = "";
}
