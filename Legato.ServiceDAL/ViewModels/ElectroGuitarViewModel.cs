namespace Legato.ServiceDAL.ViewModels
{
    public class ElectroGuitarViewModel : GuitarViewModel
    {
        public byte StringNumber { get; set; }

        public bool HasTremoloBar { get; set; }

        public string Soundbox { get; set; }

        public short StringCaliber { get; set; }
    }
}
