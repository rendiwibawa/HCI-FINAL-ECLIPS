using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleObject : MonoBehaviour
{
    // Objek yang ingin disembunyikan
    public GameObject objectToHide;

    // Tombol yang digunakan untuk menyembunyikan objek
    public Button hideButton;

    void Start()
    {
        // Menambahkan event listener ke tombol ketika game dimulai
        hideButton.onClick.AddListener(HideObject);
    }

    // Fungsi untuk menyembunyikan objek
    public void HideObject()
    {
        // Mengatur objek menjadi tidak aktif
        objectToHide.SetActive(false);
    }
}
