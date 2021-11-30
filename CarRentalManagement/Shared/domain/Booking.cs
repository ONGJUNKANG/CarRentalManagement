using System;

namespace CarRentalManagement.Shared.domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicale { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }


    }
}