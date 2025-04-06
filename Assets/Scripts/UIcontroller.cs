using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    // Lista que contiene todas las ventanas UI activas en pantalla
    [SerializeField] private List<GameObject> UI;
    private void Update()
    {
        // Verifica si el jugador presion� la tecla ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Llama al m�todo que cierra la �ltima ventana abierta
            Print();
        }
    }
    // M�todo encargado de cerrar la �ltima ventana UI abierta
    private void Print()
    {
        // Si a�n hay ventanas en la lista
        if (UI.Count > 0)
        {
            // Muestra en consola el nombre de la �ltima ventana abierta
            Debug.Log("Nombre: " + UI[UI.Count - 1].name);
            // Guarda la referencia del GameObject (�ltima ventana)
            GameObject ventana = UI[UI.Count - 1];
            // Lo elimina de la lista para que ya no sea considerado como ventana activa
            UI.RemoveAt(UI.Count - 1); 
            Destroy(ventana);
            // Muestra cu�ntas ventanas quedan en la lista
            Debug.Log("Ventanas Abiertas: " + UI.Count);
        }
        else
        {
            Debug.Log("Ya no hay mas ventanas");
        }
        
    }
}
