using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class StopwatchController : MonoBehaviour
{
    public Text stopwatchText; // Referensi ke elemen teks untuk menampilkan stopwatch
    private float elapsedTime; // Waktu yang telah berlalu
    private bool isRunning; // Status apakah stopwatch sedang berjalan atau tidak
    private bool isFirstObjectFallen = false; // Status apakah benda pertama sudah jatuh atau tidak
    public Transform M1; // Referensi ke benda pertama
    public Transform plane; // Referensi ke plane sebagai titik berhenti stopwatch



    void Start()
    {
        ResetStopwatch();
        StartStopwatch();
    }

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateStopwatchUI();

            // Deteksi tabrakan antara benda pertama dan plane
            if (!isFirstObjectFallen && M1.position.y <= plane.position.y)
            {
                isFirstObjectFallen = true;
                StopStopwatch();
            }
        }
    }

    void UpdateStopwatchUI()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 1000) % 1000);

        stopwatchText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    public void StartStopwatch()
    {
        isRunning = true;
    }

    public void StopStopwatch()
    {
        isRunning = false;
    }

    public void ResetStopwatch()
    {
        elapsedTime = 0;
        isRunning = false;
        UpdateStopwatchUI();
    }
}
