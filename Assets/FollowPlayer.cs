using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent m_Agent;
    public bool follow;

    private void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (follow)
        m_Agent.destination = target.position;
    }
}
