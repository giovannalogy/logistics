public sealed record GetNotificacaoResponse
{
   public Guid Id { get; set; }
   public Receiver Receiver{ get; set; }
   public List<Product> Products { get; set; }
}
