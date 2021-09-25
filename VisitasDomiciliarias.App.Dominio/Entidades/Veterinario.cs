using System;

namespace VisitasDomiciliarias.App.Dominio
{

public class Veterinario : Persona 
    public String TarjetaProfesional {get; set;}

    private Visita visita;

    public Visita GetVisita()
    {
        return this.visita;
    }

    public void SetVisita(Visita value)
    {
        this.visita = value;
    }
}