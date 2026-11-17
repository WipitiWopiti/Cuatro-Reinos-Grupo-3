using UnityEngine;

public class Unidad : MonoBehaviour
{
    public UnidadDatos stats;
    public Unidad objetivo;

    public string nombre;
    public int tier;
    public string rol;
    public string rasgo;
    public int vidaActual;
    public int ataque;
    public int armadura;
    public int vel_movimiento;

    public bool muerto = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nombre = stats.nombre;
        tier = stats.tier;
        rol = stats.rol;
        rasgo = stats.rasgo;
        vidaActual = stats.vida;
        ataque = stats.ataque;
        armadura = stats.armadura;
        vel_movimiento = stats.vel_movimiento;

        combate();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void atacar()
    {
        Debug.Log("Hola desde atacar");
        int danio = ataque - objetivo.armadura;
        objetivo.recibirDanio(danio);
    }

    void recibirDanio(int danio)
    {
        Debug.Log("AU AU");
        vidaActual -= danio;
        Debug.Log("Vida actual de " + nombre + ": " + vidaActual);
        if (vidaActual <= 0)
        {
            vidaActual = 0;
            muerto = true;
            Debug.Log("Combate terminado");
        }
    }

    void combate()
    {
    while (muerto == false && objetivo.muerto == false)
        {
            Debug.Log("Hola desde combate");
            atacar();
        }
    }
}
