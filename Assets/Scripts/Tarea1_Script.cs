using UnityEngine;

public class Tarea1_Script : MonoBehaviour
{
    public GameObject prender;

    public GameObject cambiarposicion;

    public void PrenderApagar()
    {
        Renderer renderer = prender.GetComponent<Renderer>();

        renderer.enabled = !renderer.enabled;
    }

    public void MoverPosicion()
    {
        float x = Random.Range(0f, 20f);
        float y = Random.Range(0f, 20f);
        float z = Random.Range(0f, 20f);

        cambiarposicion.transform.position = new Vector3(x, y, z);
    }
}