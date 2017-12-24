using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public class HeroController : MonoBehaviour {

    private NavMeshAgent agent;
    private ParticleSystem particleSystem;

    void Start() {
        agent = GetComponent<NavMeshAgent> ();
        particleSystem = GetComponent<ParticleSystem> ();
    }

    void Update() {
        if (GameController.instance.IsPaused) {
            agent.isStopped = true;
            return;
        } else {
            agent.isStopped = false;
        }

        RaycastHit hit;
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            if (Physics.Raycast (ray, out hit)) {
                agent.SetDestination (hit.point);
            }

            particleSystem.Play (false);
        }
    }
}
