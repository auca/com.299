using UnityEngine;

public class BallController : MonoBehaviour {

        public float InputForceScale =
                10.0f;
        public float InitialAngle =
                20.0f;

        private Rigidbody rigidBody;

        void Start () {
                rigidBody =
                        GetComponent<Rigidbody> ();

                Vector3 force =
                        Quaternion.Euler (0.0f, InitialAngle, 0.0f) *
                                Vector3.forward * InputForceScale;

                rigidBody.AddForce (force);
        }

}

