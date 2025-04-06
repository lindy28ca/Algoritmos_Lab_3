using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    // Lista que contiene todas las ventanas UI activas en pantalla
    [SerializeField] private List<GameObject> UI;
    private void Update()
    {
        // Verifica si el jugador presionó la tecla ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Llama al método que cierra la última ventana abierta
            Print();
        }
    }
    // Método encargado de cerrar la última ventana UI abierta
    private void Print()
    {
        // Si aún hay ventanas en la lista
        if (UI.Count > 0)
        {
            // Muestra en consola el nombre de la última ventana abierta
            Debug.Log("Nombre: " + UI[UI.Count - 1].name);
            // Guarda la referencia del GameObject (última ventana)
            GameObject ventana = UI[UI.Count - 1];
            // Lo elimina de la lista para que ya no sea considerado como ventana activa
            UI.RemoveAt(UI.Count - 1); 
            Destroy(ventana);
            // Muestra cuántas ventanas quedan en la lista
            Debug.Log("Ventanas Abiertas: " + UI.Count);
        }
        else
        {
            Debug.Log("Ya no hay mas ventanas");
        }
        
    }
}
