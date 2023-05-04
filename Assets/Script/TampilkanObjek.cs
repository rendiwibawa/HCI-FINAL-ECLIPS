using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TampilkanObjek : MonoBehaviour
{
    // Objek yang ingin 
    public GameObject objectToshow;

    // Tombol yang digunakan untuk  objek
    public Button showButton;

    void Start()
    {
        // Menambahkan event listener ke tombol ketika game dimulai
        showButton.onClick.AddListener(showObject);
    }

    // Fungsi untuk  objek
    public void showObject()
    {
        // Mengatur objek menjadi aktif
        objectToshow.SetActive(true);
    }
}
