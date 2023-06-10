namespace PizzaPlace.Shared
{
  public class Estado
  {
    public Menu Menu { get; } = new Menu();     
    public CompraCesta Cesta { get; } = new CompraCesta();
    public Interfaz Interfaz { get; set; } = new Interfaz();
  }
}

