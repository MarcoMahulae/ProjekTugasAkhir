using UnityEngine;

public class ElevatorTip : MonoBehaviour
{
    public bool isTouchingSisaAkar = false;
    public GameObject akarGigiTarget;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SisaAkarGigi"))
        {
            isTouchingSisaAkar = true;
            akarGigiTarget = other.gameObject;
            Debug.Log("Ujung elevator menyentuh sisa akar gigi!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SisaAkarGigi"))
        {
            isTouchingSisaAkar = false;
            akarGigiTarget = null;
            Debug.Log("Ujung elevator menjauh dari sisa akar gigi.");
        }
    }
}
