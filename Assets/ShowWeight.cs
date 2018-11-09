using UnityEngine;

public class ShowWeight : MonoBehaviour {

	// Use this for initialization
	public GetWeight weight;
	public string displayWeight;
	// void Start () {
	// 	displayWeight = weight.getMass().ToString();
	// 	GetComponent<TextMesh>().text = string.Format("{0} lb | On", displayWeight);
	// }
	
	// Update is called once per frame	
	void Update () {
		// Debug.Log(displayWeight);
		displayWeight = weight.getMass().ToString();
		GetComponent<TextMesh>().text = string.Format("{0} lb | Off", displayWeight);
	}
}
