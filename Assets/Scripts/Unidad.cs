using UnityEngine;

public class Unidad : MonoBehaviour
{
    public UnidadDatos stats;

    public string nombre;
    public int tier;
    public string rol;
    public string rasgo;
    public int vida;
    public int ataque;
    public int armadura;
    public int vel_movimiento;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nombre = stats.nombre;
        tier = stats.tier;
        rol = stats.rol;
        rasgo = stats.rasgo;
        vida = stats.vida;
        ataque = stats.ataque;
        armadura = stats.armadura;
        vel_movimiento = stats.vel_movimiento;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
