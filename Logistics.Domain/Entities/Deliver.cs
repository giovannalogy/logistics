
using Logistica.Domain.Entities;

public class Deliver : BaseEntity
{
    public bool DeliveryDone { get; set; }
    public int attempts { get; set; }
}
