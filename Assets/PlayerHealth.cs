using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public float max_Health = 100.0f;
	public float cur_Health = 0.0f;
	public GameObject healthBar;
	// Use this for initialization
	void Start () {
		cur_Health = max_Health;
		InvokeRepeating ("decreasehealth",1.0f,1.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void decreasehealth()
	{
		cur_Health -= 2;
		float calc_Health = cur_Health / max_Health;
		SetHealthBar (calc_Health);
	}
	public void SetHealthBar(float myHealth)
	{
		healthBar.transform.localScale = new Vector3 (myHealth,healthBar.transform.localScale.y,healthBar.transform.localScale.z);
	}
}
