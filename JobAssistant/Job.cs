namespace JobAssistant
{
    public class Job
    {
        private int jobID;
        private string ingilizce;
        private string pozisyon;
        private string okul;
        private string yer;
        private string marka;
        private string aciklama;

        public int JobID
        {
            get => jobID;
            set => jobID = value;
        }

        public string Ingilizce
        {
            get => ingilizce;
            set => ingilizce = value;
        }

        public string Pozisyon
        {
            get => pozisyon;
            set => pozisyon = value;
        }

        public string Okul
        {
            get => okul;
            set => okul = value;
        }

        public string Yer
        {
            get => yer;
            set => yer = value;
        }

        public string Marka
        {
            get => marka;
            set => marka = value;
        }

        public string Aciklama
        {
            get => aciklama;
            set => aciklama = value;
        }
    }
}