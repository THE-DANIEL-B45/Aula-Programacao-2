using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public FollowPlayer enemy;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enemy.follow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enemy.follow = false;
        }
    }
}
