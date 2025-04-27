using UnityEngine;

public class GoyangSisaAkar : MonoBehaviour
{
    private bool isGoyang = false;
    private Transform elevatorTransform;
    private Vector3 offset;

    void Update()
    {
        if (isGoyang && elevatorTransform != null)
        {
            // Gerakkan posisi sisa akar mengikuti gerakan elevator + sedikit offset
            transform.position = elevatorTransform.position + offset;
        }
    }

    public void MulaiGoyang(Transform elevator)
    {
        elevatorTransform = elevator;
        offset = transform.position - elevator.position;
        isGoyang = true;
    }

    public void BerhentiGoyang()
    {
        isGoyang = false;
        elevatorTransform = null;
    }
}
