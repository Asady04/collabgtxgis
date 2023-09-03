using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button tombolInteraksi; // Tombol yang akan muncul.
    private bool pemainMendekati = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Cek apakah yang masuk ke trigger adalah pemain.
        if (collision.CompareTag("Player"))
        {
            pemainMendekati = true;
            tombolInteraksi.gameObject.SetActive(true); // Munculkan tombol jika pemain mendekati objek.
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Cek apakah pemain meninggalkan trigger.
        if (other.CompareTag("Player"))
        {
            pemainMendekati = false;
            tombolInteraksi.gameObject.SetActive(false); // Sembunyikan tombol jika pemain meninggalkan objek.
        }
    }
}