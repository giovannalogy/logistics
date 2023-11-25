public sealed record GetNotificationByIdResponse
{   
    public readonly string Id;
    public Receiver Receiver { get; set; }
    public List<Product> Products { get; set; }
}
