using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTarget : MonoBehaviour
{
    public Transform target, shoulder;
    // Update is called once per frame
    void Update()
    {
        float distToShoulder = Vector3.Distance(target.position, shoulder.position);
        Debug.Log(distToShoulder);
        
        float offset = (1 - (distToShoulder/2f)) * 3.55f;

        if(distToShoulder < 2)
            this.transform.position = target.position - new Vector3(0,0, offset);
            else
            this.transform.position = target.position;

        
    }
}
