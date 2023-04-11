namespace Models
{
    public class PrihvacenaTura
    {

        [Key]
        public int ID { get; set; }

        public Tura? Tura { get; set; }

        public Vozac? Vozac { get; set; }

        public Vozilo? Vozilo { get; set; }

        public double GenerisanaCena { get; set; }
    }
}