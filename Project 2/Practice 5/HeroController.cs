using UnityEngine;

public class HeroController : MonoBehaviour {

	private NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}

	void Update () {
		if (GameManager.instance.IsPaused) {
			return;
		}

		if (Input.GetMouseButtonDown (0)) {
			Ray ray =
				Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit result;
			if (Physics.Raycast (ray, out result, 100)) {
				agent.SetDestination (result.point);
			}
		}
	}
}
