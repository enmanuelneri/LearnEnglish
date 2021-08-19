using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscenas : MonoBehaviour
{
    public void cargarEscena(string nombreEscena){
        SceneManager.LoadScene(nombreEscena);
    }    
    
}
