using UnityEngine;

public class BallController : MonoBehaviour {

        public float InputForceScale =
                10.0f;
        public float InitialAngle =
                20.0f;

        public AudioClip WallSound;
        public AudioClip PaddleSound;

        private AudioSource audioSource;
        private Rigidbody rigidBody;

        void Start () {
                audioSource =
                        GetComponent<AudioSource> ();

                rigidBody =
                        GetComponent<Rigidbody> ();

                Vector3 force =
                        Quaternion.Euler (0.0f, InitialAngle, 0.0f) * Vector3.forward *
                            InputForceScale;

                rigidBody.AddForce (force);
        }

        void OnCollisionEnter(Collision collision) {
                GameObject gameObject =
                        collision.gameObject;

                if (gameObject.CompareTag ("Wall")) {
                        audioSource.PlayOneShot (WallSound);
                } else if (gameObject.CompareTag ("Paddle")) {
                        audioSource.PlayOneShot (PaddleSound);
                }
        }

}

