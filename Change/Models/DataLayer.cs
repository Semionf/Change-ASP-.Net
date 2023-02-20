using System.Data.Entity;
using System.Threading;

namespace Change.Models
{
    public class DataLayer: DbContext
    {
        public User GetUser = new User { FirstName = "התחבר"};

        private static DataLayer data;
        private DataLayer() : base("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Change;Data Source=localhost\\SQLEXPRESS")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataLayer>());

            //כאשר מסד הנתונים ריק, נפעיל את הפונקציה הזורעת
            if (Users.Count() == 0) seed();
        }

        public static DataLayer Data
        {
            get

            {
                if (data == null) data = new DataLayer();
                return data;
            }
        }

        private void seed()
        {
            //מנהל המערכת
            Manager manager = new Manager { FirstName = "סמיון", LastName = "פורלנדר", Email = "sfurlender@gmail.com", Password = "1234", PhoneNumber = "05444", StartWorkingDate = DateTime.Now };
            Users.Add(manager);
            Employee employee = new Employee { FirstName = "אבי", LastName = "לוי", Email = "mail@mail.com", Password = "1234", PhoneNumber = "058333" };
            Users.Add(employee);

            SaveChanges();
        }

        public List<User> AllUsers
        {
            get
            {
                List<User> Users = DataLayer.data.Users.ToList();
                return Users;
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CashRegister> CashRegisters { get;set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Currency> Coins { get; set; }

    }
}
