using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public enum EnemyState {
    Patrolling,
    Following,
    Returning
}

public class EnemyController : MonoBehaviour {
    public float MinDistanceToFollow = 10.0f;
    public float MinDistanceToPatrolPoint = 2.0f;

    public GameObject PointToPatroll;
    public float patrollAreaRadius = 4.0f;

    private NavMeshAgent agent;
    private EnemyState state;

    private HeroController hero;

    void Start () {
        agent = GetComponent<NavMeshAgent> ();
        state = EnemyState.Patrolling;

        hero = FindObjectOfType<HeroController> ();
    }

    void Update () {
        if (GameController.instance.IsPaused) {
            agent.isStopped = true;
        } else {
            agent.isStopped = false;
        }

        if (state == EnemyState.Patrolling) {
            Patrol ();
        } else if (state == EnemyState.Following) {
            Follow ();
        } else if (state == EnemyState.Returning) {
            Return ();
        }
    }

    private void Patrol () {
        if (!agent.hasPath) {
            Vector2 randomPoint = Random.insideUnitCircle;
            randomPoint *= patrollAreaRadius;

            Vector3 destination = PointToPatroll.transform.position;
            destination.x += randomPoint.x;
            destination.z += randomPoint.y;

            agent.SetDestination (destination);
        }

        float distance = Vector3.Distance (transform.position, hero.transform.position);
        if (distance < MinDistanceToFollow) {
            state = EnemyState.Following;
            agent.ResetPath ();
        }
    }

    private void Follow () {
        if (!agent.hasPath) {
            agent.SetDestination (hero.transform.position);
        }

        float distance = Vector3.Distance (transform.position, hero.transform.position);
        if (distance >= MinDistanceToFollow) {
            state = EnemyState.Returning;
            agent.ResetPath ();
        }
    }

    private void Return () {
        if (!agent.hasPath) {
            Vector3 destination = PointToPatroll.transform.position;
            agent.SetDestination (destination);
        }

        if (Vector3.Distance(transform.position, hero.transform.position) < MinDistanceToFollow) {
            state = EnemyState.Following;
            agent.ResetPath ();
        } else if (Vector3.Distance(transform.position, PointToPatroll.transform.position) < MinDistanceToPatrolPoint) {
            state = EnemyState.Patrolling;
            agent.ResetPath ();
        }
    }

}

