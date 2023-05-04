using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{

    // Nama Scene yang akan dituju
    public string sceneName;

    // Fungsi untuk memuat scene baru saat tombol diklik
    public void ChangeToScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
