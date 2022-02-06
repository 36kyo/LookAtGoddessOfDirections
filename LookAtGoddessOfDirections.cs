using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Transform goddessOfDirections; // 歳徳神

    void Update()
    {
        Vector3 relativePos = goddessOfDirections.position - transform.position;

        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
}
