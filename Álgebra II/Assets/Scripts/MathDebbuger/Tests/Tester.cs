using System.Collections.Generic;
using UnityEngine;
using MathDebbuger;
using CustomMath;

public class Tester : MonoBehaviour
{
    public enum Ejercicios
    {
        Uno,
        Dos,
        Tres,
        Cuatro,
        Cinco,
        Seis,
        Siete,
        Ocho,
        Nueve,
        Diez
    }
    public Ejercicios ejercicio = Ejercicios.Uno;

    public Color vectorColor = Color.red;

    public Vector3 A = Vector3.zero;
    public Vector3 B = Vector3.zero;
    public Vector3 C = Vector3.zero;

    void Start()
    {
        VectorDebugger.EnableCoordinates();
        VectorDebugger.AddVector(A, Color.white, "A");
        VectorDebugger.AddVector(B, Color.black, "B");
        VectorDebugger.AddVector(C, vectorColor, "C");
        /*List<Vector3> vectors = new List<Vector3>();
        vectors.Add(new Vec3(10.0f, 0.0f, 0.0f));
        vectors.Add(new Vec3(10.0f, 10.0f, 0.0f));
        vectors.Add(new Vec3(20.0f, 10.0f, 0.0f));
        vectors.Add(new Vec3(20.0f, 20.0f, 0.0f));
        VectorDebugger.AddVectorsSecuence(vectors, false, Color.red, "secuencia");
        VectorDebugger.AddVector(new Vector3(10, 10, 0), Color.blue, "elAzul");
        VectorDebugger.AddVector(Vector3.down * 7, Color.green, "elVerde");*/
        VectorDebugger.EnableEditorView();
    }

    void Update()
    {
        switch ((int)ejercicio)
        {
            case 0:
                {
                    C = A + B;
                    break;
                }
            case 1:
                {
                    C = B - A;
                    break;
                }
            case 2:
                {
                    C = new Vector3(A.x * B.x, A.y * B.y, A.z * B.z);
                    break;
                }
            case 3:
                {

                    break;
                }
            case 4:
                {

                    break;
                }
            case 5:
                {

                    break;
                }
            case 6:
                {

                    break;
                }
            case 7:
                {

                    break;
                }
            case 8:
                {

                    break;
                }
            case 9:
                {

                    break;
                }
        }

        MathDebbuger.VectorDebugger.UpdatePosition("A", A);
        MathDebbuger.VectorDebugger.UpdatePosition("B", B);
        MathDebbuger.VectorDebugger.UpdatePosition("C", C);
    }
}
