namespace PizzaPlace.Shared
{
  public class CompraCesta
  {
    public Cliente Cliente { get; set; } = new Cliente();     
    public List<int> Pedidos { get; set; } = new List<int>();     
    public bool HaPagado { get; set; }
    public void Agregar(int Id){
      Pedidos.Add(Id);
    }
  }
}
