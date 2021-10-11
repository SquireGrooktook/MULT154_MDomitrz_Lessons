using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmBrain : MonoBehaviour
{

    private bool hasHive = true;
    private Patrolling patrol;
    private Bot bot;
    // Start is called before the first frame update
    void Start()
    {
        patrol = GetComponent<Patrolling>();
        bot = GetComponent<Bot>();
        HivePickUp.HivePickedUp += HiveTaken;
    }

    void HiveTaken()
    {
        hasHive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasHive == true)
        {
            patrol.PatrolWayPoints();
        } else
        {
            bot.Pursue();
        }
    }
}
