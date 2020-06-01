using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour
{

    int speedRotate = 300;
        void Update()
    {
        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
    }
}