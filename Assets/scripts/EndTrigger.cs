using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager Manager;
    private void OnTriggerEnter(Collider other)
    {
        Manager.CompleteLevel();
    }
}
