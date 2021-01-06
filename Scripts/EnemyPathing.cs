using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
     WaveConfig waveConfig;
     List<Transform> waypoints;
    
    int waypointIndex = 0;
    
    void Start()
    {
        waypoints = waveConfig.Getwaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {

        this.waveConfig = waveConfig;

    }



    private void move()
    {
        if (waypointIndex <= waypoints.Count - 1)

        {
            var targetPosition = waypoints[waypointIndex].transform.position;
            var movementThisFrame = waveConfig.GetmoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);
           
            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
