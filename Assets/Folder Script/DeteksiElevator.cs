using UnityEngine;

public class DeteksiElevator : MonoBehaviour
{
    public ElevatorCameraFokus kameraFokus; // Drag Main Camera (yang punya script ElevatorCameraFokus) ke sini

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SisaAkarGigi"))
        {
            GoyangSisaAkar goyangScript = other.GetComponent<GoyangSisaAkar>();
            if (goyangScript != null)
            {
                goyangScript.MulaiGoyang(transform);
                Debug.Log("Ujung elevator menyentuh sisa akar gigi! Mulai bisa digoyangkan.");

                if (kameraFokus != null)
                {
                    kameraFokus.AktifkanFokus();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SisaAkarGigi"))
        {
            GoyangSisaAkar goyangScript = other.GetComponent<GoyangSisaAkar>();
            if (goyangScript != null)
            {
                goyangScript.BerhentiGoyang();
                Debug.Log("Ujung elevator menjauh dari sisa akar gigi. Berhenti menggoyang.");

                if (kameraFokus != null)
                {
                    kameraFokus.NonaktifkanFokus();
                }
            }
        }
    }
}
