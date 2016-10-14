using UnityEngine;

public class BallController : MonoBehaviour {

        public float InputForceScale =
                10.0f;

        private Rigidbody rigidBody;

        void Start () {
                rigidBody =
                        GetComponent<Rigidbody> ();
        }

        void FixedUpdate () {
                float horizontalAxis =
                        Input.GetAxis ("Horizontal");
                float verticalAxis =
                        Input.GetAxis ("Vertical");

                Vector3 force =
                        new Vector3 (horizontalAxis, 0.0f, verticalAxis) *
                                InputForceScale;

                rigidBody.AddForce (force);
        }

}

