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
    public float vel_ataque;
    public float rango_ataque = 0;
    public float tiempoUltimoAtaque = 0;

    public bool muerto = false;

    public int equipo = -1;

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
        vel_ataque = stats.vel_ataque;
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo != null && objetivo.muerto == false){
            combate();
            moverse();
        } 
    }

    void atacar()
    {
        if (objetivo.equipo != equipo)
        {
            int danio = Mathf.Max(0, ataque - objetivo.armadura);
            objetivo.recibirDanio(danio);
        }
    }

    void recibirDanio(int danio)
    {   
        vidaActual -= danio;
        Debug.Log("Vida actual de " + nombre + ": " + vidaActual);
        if (vidaActual <= 0)
        {
            vidaActual = 0;
            muerto = true;
            Destroy(gameObject);
            Debug.Log("Combate terminado");
        }
    }

    void combate()
    {
        float distancia = Vector3.Distance(transform.position, objetivo.transform.position);
        if (distancia <= rango_ataque)
        {
            tiempoUltimoAtaque += Time.deltaTime;
            if (tiempoUltimoAtaque >= 1)
            {
                atacar();
                tiempoUltimoAtaque = 0;
            }
        }
    }
    void moverse()
    {
        float distancia = Vector3.Distance(transform.position, objetivo.transform.position);
        if (distancia > rango_ataque)
        {
            transform.position = Vector3.MoveTowards( transform.position, objetivo.transform.position, vel_movimiento * Time.deltaTime);
        };
    }
}