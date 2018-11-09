using UnityEngine;

public class GetWeight : MonoBehaviour {

	public float mass;

	// Use this for initialization
	void Start () {
		mass = 0;	
	}
	
	// Update is called once per frame
	// void Update () {
		
	// }
	public void OnCollisionEnter(Collision col) {
		if (col.collider.gameObject.layer == LayerMask.NameToLayer("Item")) {
			this.mass = col.collider.GetComponent<Rigidbody>().mass;
			Debug.Log("Collided!");
			Debug.Log(this.mass);
		}
		
		// this.mass = 1.57f;
	}

	public void OnCollisionExit(Collision col) {
		if (col.collider.gameObject.layer == LayerMask.NameToLayer("Item")) {
			this.mass = 0f;
		}
	}

	public float getMass() {
		return mass;
	}
}
