using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    private NavMeshAgent m_agent;
    private RaycastHit m_hitinfo = new RaycastHit();

    private void Start()
    {
        m_agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray.origin, ray.direction, out m_hitinfo))
            {
                m_agent.destination = m_hitinfo.point;
            }
        }
    }
}
