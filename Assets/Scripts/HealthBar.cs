using UnityEngine;

public class HealthBar : MonoBehaviour
{
	public Transform heartPrefab;
	private int hp;

	void Start()
	{
		hp = transform.parent.GetComponent<HealthScript> ().hp;

		for(var i = 0; i < hp; i++) {
			var heart = Instantiate(heartPrefab) as Transform;
			heart.parent = transform;

			var offset = new Vector3(0.6f*i,0,0);
			heart.position = transform.position + offset;
		}
	}
	 
	void Update()
	{
		hp = transform.parent.GetComponent<HealthScript> ().hp;
		var i = 1;

		foreach(Transform heart in transform) {
			if(i > hp) {
				Destroy(heart.gameObject);
			}
			i++;
		}
	}
}
