using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Goal"))
        {
            TaskManager.Instance.IncGoal();
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            TaskManager.Instance.DecGoal();
        }            
    }
}
