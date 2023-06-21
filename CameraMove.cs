using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform PlayerTransform;
    public Rigidbody PlayerRigidbody; 
    public List<Vector3> VelocityList = new List<Vector3>();

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            VelocityList.Add(Vector3.zero);
        }
    }
    private void FixedUpdate()
    {
        VelocityList.Add(PlayerRigidbody.velocity);
        VelocityList.RemoveAt(0);
    }


    void Update()
    {
        transform.position = PlayerTransform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(PlayerRigidbody.velocity), Time.deltaTime*10);
        
    }
}
