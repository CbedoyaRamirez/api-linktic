namespace ApiPruebaLinktic.Entities
{
    public class Reservation
    {

        public int id { get; set; }

        public int idcliente { get; set; }

        public DateTime datereservation { get; set; }

       public int status { get; set; }

       public string? obervations { get; set; }

       public int numPerson { get; set; }

    }
}
