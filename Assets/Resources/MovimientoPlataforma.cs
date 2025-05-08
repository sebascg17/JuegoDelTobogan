using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public float velocidad = 2f;

    private Vector3 destinoActualLocal;

    void Start ()
    {
        // Calculamos posiciones relativas locales
        destinoActualLocal = transform.parent.InverseTransformPoint(puntoB.position);
    }

    void Update ()
    {
        // Movimiento en coordenadas locales respecto a la pista
        Vector3 posicionLocal = transform.localPosition;
        Vector3 destinoLocal = destinoActualLocal;

        transform.localPosition = Vector3.MoveTowards(posicionLocal, destinoLocal, velocidad * Time.deltaTime);

        if (Vector3.Distance(posicionLocal, destinoLocal) < 0.01f)
        {
            // Cambiar destino local entre punto A y B
            destinoActualLocal = (destinoActualLocal == transform.parent.InverseTransformPoint(puntoA.position)) ?
                                 transform.parent.InverseTransformPoint(puntoB.position) :
                                 transform.parent.InverseTransformPoint(puntoA.position);
        }
    }
}
