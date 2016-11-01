using UnityEngine;
using System.Collections.Generic;

public class populateGraph : MonoBehaviour {

	public GameObject EmptyGraphTest;

	public WMG_Axis_Graph myGraph;

	public WMG_Series dummySeries;

	public List <Vector2> dummyData;

	// Use this for initialization
	void Start () {
		GameObject myGraphCreate = GameObject.Instantiate (EmptyGraphTest);
		myGraphCreate.transform.SetParent (this.transform, false);

		myGraph = myGraphCreate.GetComponent<WMG_Axis_Graph> ();

		dummySeries = myGraph.addSeries();
	}
	

}
