using UnityEngine;

public class Agent : SBAgent
{
	public Transform target;

	void Start()
	{
		maxSpeed = 10f;
		maxSteer = 0.5f;
	}

	void Update()
	{
		velocity += SteeringBehaviours.Arrive(this, target, 3);
		velocity += SteeringBehaviours.Separate(this, GameManager.agents, 2f);
		transform.position += velocity * Time.deltaTime;

        if (transform.position.y < -4 || transform.position.y > 4)  {
			velocity.y *= -1;
        }

        if (transform.position.x < -4 || transform.position.x > 4) {
            velocity.x *= -1;
        }
	}
}