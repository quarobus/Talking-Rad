using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public void PlayCredit()
    {
        SceneManager.LoadScene("Credits");
    }
}
