using UnityEngine;

[CreateAssetMenu(fileName = "NuevaUnidad", menuName = "Scriptable Objects/NuevaUnidad")]
public class UnidadDatos : ScriptableObject
{
    public string nombre;
    public int tier;
    public string rol;
    public string rasgo;
    public int vida;
    public int ataque;
    public int armadura;
    public int vel_movimiento;
}
