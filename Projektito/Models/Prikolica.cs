namespace Models 
{

    public class Prikolica{

        [Key]
        public int ID { get; set; }
        [RegularExpression("^[a-zA-z]+$")]
        public required string Tip { get; set; }
        [RegularExpression(@"^(0*[1-9]\d{0,15}|0+)(\.\d\d)?$")]
        public double Zapremina { get; set; }
        [RegularExpression(@"^(0*[1-9]\d{0,15}|0+)(\.\d\d)?$")]
        public double Duzina { get; set; }
        [RegularExpression(@"^(0*[1-9]\d{0,15}|0+)(\.\d\d)?$")]
        public double Sirina { get; set; }
        [RegularExpression(@"^(0*[1-9]\d{0,15}|0+)(\.\d\d)?$")]
        public double Visina { get; set; }
        [RegularExpression(@"^(0*[1-9]\d{0,15}|0+)(\.\d\d)?$")]
        public double Nosivost { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9\_]+$")]
        [MaxLength(11)]
        public required string Tablice { get; set; }
        public required string Slika { get; set; }

    }
}