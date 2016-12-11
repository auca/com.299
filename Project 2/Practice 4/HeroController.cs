using UnityEngine;

public class HeroController : MonoBehaviour {

	public float Speed = 2.0f;

	private ParticleSystem ps;
	private bool dead = false;

	void Start() {
		ps = GetComponent<ParticleSystem> ();
	}

	void Update () {
		if (dead) {
			return;
		}

		float horizontalAxis =
			Input.GetAxis ("Horizontal");
		float verticalAxis =
			Input.GetAxis ("Vertical");

		Vector3 shift =
			new Vector3 (horizontalAxis, 0.0f, verticalAxis);
		shift *=
			Speed * Time.deltaTime;

		transform.position +=
			shift;
	}

	public void Die() {
		dead = true;
		ps.Play ();
		Destroy (this.gameObject, ps.main.duration);
	}

}
