using UnityEngine;

public class ElevatorCameraFokus : MonoBehaviour
{
    public Transform target; // Target yang difokuskan (GusidanGigi atau objek lainnya)
    public float smoothSpeed = 0.125f; // Kecepatan smooth camera mengikuti target
    public Vector3 offset; // Jarak offset kamera dari target

    private bool isFokus = false; // Untuk mengecek apakah kamera fokus ke target

    void Update()
    {
        if (isFokus && target != null)
        {
            // Mendapatkan posisi baru dengan offset
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Fokus kamera ke target
            transform.LookAt(target);

            Debug.Log("Kamera fokus ke: " + target.name); // Log saat kamera fokus
        }
    }

    // Fungsi untuk mengaktifkan fokus kamera
    public void AktifkanFokus()
    {
        isFokus = true;
        Debug.Log("Kamera mulai fokus!"); // Log saat fokus diaktifkan
    }

    // Fungsi untuk menonaktifkan fokus kamera
    public void NonaktifkanFokus()
    {
        isFokus = false;
        Debug.Log("Kamera berhenti fokus!"); // Log saat fokus dinonaktifkan
    }
}
