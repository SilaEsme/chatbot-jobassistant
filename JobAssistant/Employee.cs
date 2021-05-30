namespace JobAssistant
{
    public class Employee
    {
        private string NameSurname;
        private string Adres;
        private string Telefon;
        private string DogumYeri;
        private string Eposta;
        private string Username;
        private string Password;
        private string DogumTarihi;

        public EmployeeList employeeList = EmployeeList.CreateSingle();

        public Employee()
        {
        }

        public Employee(string NameSurname, string Adres, string Telefon, string DogumYeri, string Eposta,
            string Username, string Password, string DogumTarihi)
        {
            this.NameSurname = NameSurname;
            this.Adres = Adres;
            this.Telefon = Telefon;
            this.DogumYeri = DogumYeri;
            this.Eposta = Eposta;
            this.Username = Username;
            this.Password = Password;
            this.DogumTarihi = DogumTarihi;
        }

        public string nameSurname
        {
            get { return NameSurname; }
            set { NameSurname = value; }
        }

        public string adres
        {
            get { return Adres; }
            set { Adres = value; }
        }

        public string telefon
        {
            get { return Telefon; }
            set { Telefon = value; }
        }

        public string dogumYeri
        {
            get { return DogumYeri; }
            set { DogumYeri = value; }
        }

        public string eposta
        {
            get { return Eposta; }
            set { Eposta = value; }
        }

        public string username
        {
            get { return Username; }
            set { Username = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public string dogumTarihi
        {
            get { return DogumTarihi; }
            set { DogumTarihi = value; }
        }
    }
}