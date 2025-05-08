using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float tiempoRestante = 120f;
    public TextMeshProUGUI textoCuenta;

    public PlataformaMovil plataforma; // Asigna la plataforma desde el inspector

    private bool juegoActivo = true;

    void Update ()
    {
        if (!juegoActivo) return;

        tiempoRestante -= Time.deltaTime;

        if (tiempoRestante > 0)
        {
            int segundos = Mathf.CeilToInt(tiempoRestante);
            textoCuenta.text = "Cuenta Regresiva: " + segundos + "s";
        }
        else
        {
            juegoActivo = false;
            textoCuenta.text = "Cerrando...";
            Salir();
        }
    }

    void Salir ()
    {
        Debug.Log("Cerrando el juego automáticamente...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
