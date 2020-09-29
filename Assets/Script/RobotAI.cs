using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAI : MonoBehaviour
{
    GameObject enemy;
    Animator fsm;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("robot");
        fsm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, enemy.transform.position);

        Vector3 direction = enemy.transform.position - transform.position;
        float angle = Vector3.Angle(direction, transform.forward);
        Debug.Log(angle);


        if (distance < 8 && angle < 50) {
            fsm.SetBool("EnemyInSight", true);
        } else {
            fsm.SetBool("EnemyInSight", false);
        }

    }
}
