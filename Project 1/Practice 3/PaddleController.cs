using UnityEngine;

public class PaddleController : MonoBehaviour {

        public float InputForceScale =
                300.0f;
        public float ForceAppliedToBallScale =
                4.0f;

        private Rigidbody rigidBody;

        void Start () {
                rigidBody =
                        GetComponent<Rigidbody> ();
        }

        void FixedUpdate () {
                float horizontalAxis =
                        Input.GetAxis ("Horizontal");

                Vector3 force =
                        new Vector3 (horizontalAxis, 0.0f, 0.0f) *
                                InputForceScale;

                rigidBody.AddForce (force);
        }

        void OnCollisionEnter(Collision collision) {
                GameObject gameObject =
                        collision.gameObject;

                if (gameObject.CompareTag ("Ball")) {
                        GameObject ball =
                                gameObject;

                        float shift =
                                ball.transform.position.x -
                                        transform.position.x;

                        Vector3 force =
                                new Vector3 (shift, 0.0f, 0.0f) *
                                        ForceAppliedToBallScale;

                        ball.GetComponent<Rigidbody> ().AddForce (force);
                }
        }
}

