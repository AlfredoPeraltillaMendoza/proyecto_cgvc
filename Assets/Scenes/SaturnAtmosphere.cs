using UnityEngine;

public class SaturnAtmosphere : MonoBehaviour
{
    public Material terrainMaterial; // Agregar Matrial
    public Color reddishColor = new Color(1f, 0.5f, 0.2f, 1f); // Adjust color values as needed

    void Start()
    {
        if (terrainMaterial != null)
        {
            // Da el color Principal
            terrainMaterial.color = reddishColor;
        }
        else
        {
            Debug.LogError("No hay terreno ni color.");
        }
    }
}
