using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Waypoints")]

    public List<Transform> waypoints;

    [Header("Movement Settings")]

    public float moveSpeed = 3f;

    public float waypointReachedDistance = 0.1f

    public bool loop = true 

    private RigidBody2D rb;

    private int currentWaypointIndex = 0;

    private Vector2 movementDirection;

    void Start(){

        rb = GetComponenent<RigidBody2D>()

        if (waypoints == null || waypoints.Count == 0){
            Debug.LogError("No waypoints assignet to the enemy!")
            enable = false 
            return;
        }

        SetTargetWayPoint(currentWaypointIndex);
    }

    void FixedUpdate()
    {
        MoveTowardsWaypoint()
        CheckIfWaypointReached()
    }

    void SetTargetWaypoint(int index)
{
    if (waypoints.Count == 0) return;

    currentWaypointIndex = index;
    Vector2 targetPosition = waypoints[currentWaypointIndex].position;
    movementDirection = (targetPosition - (Vector2)transform.position).normalized;
}

void MoveTowardsWaypoint()
{
    if (waypoints.Count == 0) return;

    Vector2 targetPosition = waypoints[currentWaypointIndex].position;
    movementDirection = (targetPosition - (Vector2)transform.position).normalized

    rb.linearVelocity = movementDirection * moveSpeed;
}

void CheckIfWaypointReached()
{
    if (waypoints.Count == 0) return;

    float distanceToWaypoint = Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position);

    if (distanceToWaypoint <= waypointReachedDistance)
    {
        GoToNextWaypoint();
    }
}
void GoToNextWaypoint()
{
    currentWaypointIndex++;

    if (currentWaypointIndex >= waypoints.Count)
    {
        if (loop)
        {
            currentWaypointIndex = 0;
        }
        else
        {
        
            enabled = false;
            rb.linearVelocity = Vector2.zero;
            return;
        }
    }

    SetTargetWaypoint(currentWaypointIndex);
}



}