namespace PizzaPlace.Shared
{
  public class Estado
  {
    public MenuBLL MenuBLL { get; } = new MenuBLL();     
    public CompraCesta Cesta { get; } = new CompraCesta();
    public Interfaz Interfaz { get; set; } = new Interfaz();
  }
}

