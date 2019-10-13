using Evimiz.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Evimiz.DAL
{
    public class Db_Evimiz : IdentityDbContext<ApplicationUser>
    {
        public Db_Evimiz(DbContextOptions<Db_Evimiz> options) : base(options)
        {
        }

        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Metro> Metros { get; set; }
        public DbSet<News> Newss { get; set; }
        public DbSet<NumberKeyCode> NumberKeyCodes { get; set; }
        public DbSet<NumberKeyCodeSecond> NumberKeyCodeSecondS { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PropertyCategory> PropertyCategorys { get; set; }
        public DbSet<PropertyDocument> PropertyDocuments { get; set; }
        public DbSet<PropertyRepair> PropertyRepairs { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Rank> Ranks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity(typeof(Category)).HasData(
                new Category { Id = 1, Name = "Yeni tikili" },
                new Category { Id = 2, Name = "Köhnə tikili" },
                new Category { Id = 3, Name = "Villa" },
                new Category { Id = 4, Name = "Həyət evi" },
                new Category { Id = 5, Name = "Bağ evi" },
                new Category { Id = 6, Name = "Ofis" },
                new Category { Id = 7, Name = "Qaraj" },
                new Category { Id = 8, Name = "Torpaq" },
                new Category { Id = 9, Name = "Obyekt" }
                );

            builder.Entity(typeof(PropertyCategory)).HasData(
               new PropertyCategory { Id = 1, Name = "Satılır" },
               new PropertyCategory { Id = 2, Name = "Kirayə" }
                );

            builder.Entity(typeof(Rent)).HasData(
               new Rent { Id = 1, Name = "Aylıq" },
               new Rent { Id = 2, Name = "Günluk" }
                );

            builder.Entity(typeof(PropertyRepair)).HasData(
               new PropertyRepair { Id = 1, Name = "Təmirsiz" },
               new PropertyRepair { Id = 2, Name = "Natamam təmirli" },
               new PropertyRepair { Id = 3, Name = "Zəif təmirli" },
               new PropertyRepair { Id = 4, Name = "Orta təmirli" },
               new PropertyRepair { Id = 5, Name = "Yaxşı təmirli" },
               new PropertyRepair { Id = 6, Name = "Əla təmirli" }
               );

            builder.Entity(typeof(PropertyDocument)).HasData(
               new PropertyDocument { Id = 1, Name = "Müqavilə" },
               new PropertyDocument { Id = 2, Name = "Sərəncam" },
               new PropertyDocument { Id = 3, Name = "Qeydiyyat vəsiqəsi" },
               new PropertyDocument { Id = 4, Name = "Şəhadətnamə" },
               new PropertyDocument { Id = 5, Name = "Bələdiyə sənədi" },
               new PropertyDocument { Id = 6, Name = "Kupça" },
               new PropertyDocument { Id = 7, Name = "Digər sənəd" }
               );

            builder.Entity(typeof(Room)).HasData(
                new Room { Id = 1, Count = "1" },
                new Room { Id = 2, Count = "2" },
                new Room { Id = 3, Count = "3" },
                new Room { Id = 4, Count = "4" },
                new Room { Id = 5, Count = "5" },
                new Room { Id = 6, Count = "5+" }
                );

            builder.Entity(typeof(Floor)).HasData(
               new Floor { Id = 1, Count = 1 },
               new Floor { Id = 2, Count = 2 },
               new Floor { Id = 3, Count = 3 },
               new Floor { Id = 4, Count = 4 },
               new Floor { Id = 5, Count = 5 },
               new Floor { Id = 6, Count = 6 },
               new Floor { Id = 7, Count = 7 },
               new Floor { Id = 8, Count = 8 },
               new Floor { Id = 9, Count = 9 },
               new Floor { Id = 10, Count = 10 },
               new Floor { Id = 11, Count = 11 },
               new Floor { Id = 12, Count = 12 },
               new Floor { Id = 13, Count = 13 },
               new Floor { Id = 14, Count = 14 },
               new Floor { Id = 15, Count = 15 },
               new Floor { Id = 16, Count = 16 },
               new Floor { Id = 17, Count = 17 },
               new Floor { Id = 18, Count = 18 },
               new Floor { Id = 19, Count = 19 },
               new Floor { Id = 20, Count = 20 },
               new Floor { Id = 21, Count = 21 },
               new Floor { Id = 22, Count = 22 },
               new Floor { Id = 23, Count = 23 },
               new Floor { Id = 24, Count = 24 },
               new Floor { Id = 25, Count = 25 },
               new Floor { Id = 26, Count = 26 },
               new Floor { Id = 27, Count = 27 },
               new Floor { Id = 28, Count = 29 },
               new Floor { Id = 30, Count = 30 },
               new Floor { Id = 31, Count = 31 },
               new Floor { Id = 32, Count = 32 },
               new Floor { Id = 33, Count = 33 },
               new Floor { Id = 34, Count = 34 },
               new Floor { Id = 35, Count = 35 },
               new Floor { Id = 36, Count = 36 },
               new Floor { Id = 37, Count = 37 },
               new Floor { Id = 38, Count = 38 },
               new Floor { Id = 39, Count = 39 },
               new Floor { Id = 40, Count = 40 }
               );


            builder.Entity(typeof(Rank)).HasData(
               new Rank { Id = 1, Count = 1 },
               new Rank { Id = 2, Count = 2 },
               new Rank { Id = 3, Count = 3 },
               new Rank { Id = 4, Count = 4 },
               new Rank { Id = 5, Count = 5 },
               new Rank { Id = 6, Count = 6 },
               new Rank { Id = 7, Count = 7 },
               new Rank { Id = 8, Count = 8 },
               new Rank { Id = 9, Count = 9 },
               new Rank { Id = 10, Count = 10 },
               new Rank { Id = 11, Count = 11 },
               new Rank { Id = 12, Count = 12 },
               new Rank { Id = 13, Count = 13 },
               new Rank { Id = 14, Count = 14 },
               new Rank { Id = 15, Count = 15 },
               new Rank { Id = 16, Count = 16 },
               new Rank { Id = 17, Count = 17 },
               new Rank { Id = 18, Count = 18 },
               new Rank { Id = 19, Count = 19 },
               new Rank { Id = 20, Count = 20 },
               new Rank { Id = 21, Count = 21 },
               new Rank { Id = 22, Count = 22 },
               new Rank { Id = 23, Count = 23 },
               new Rank { Id = 24, Count = 24 },
               new Rank { Id = 25, Count = 25 },
               new Rank { Id = 26, Count = 26 },
               new Rank { Id = 27, Count = 27 },
               new Rank { Id = 28, Count = 29 },
               new Rank { Id = 30, Count = 30 },
               new Rank { Id = 31, Count = 31 },
               new Rank { Id = 32, Count = 32 },
               new Rank { Id = 33, Count = 33 },
               new Rank { Id = 34, Count = 34 },
               new Rank { Id = 35, Count = 35 },
               new Rank { Id = 36, Count = 36 },
               new Rank { Id = 37, Count = 37 },
               new Rank { Id = 38, Count = 38 },
               new Rank { Id = 39, Count = 39 },
               new Rank { Id = 40, Count = 40 }
               );
            builder.Entity(typeof(City)).HasData(
                new City { Id = 1, Name = "Abşeron" },
                new City { Id = 2, Name = "Ağcabədi" },
                new City { Id = 3, Name = "Ağdam" },
                new City { Id = 4, Name = "Ağdaş" },
                new City { Id = 5, Name = "Ağstafa" },
                new City { Id = 6, Name = "Ağsu" },
                new City { Id = 7, Name = "Astara" },
                new City { Id = 8, Name = "Balakən" },
                new City { Id = 9, Name = "Beyləqan" },
                new City { Id = 10, Name = "Bakı" },
                new City { Id = 11, Name = "Bərdə" },
                new City { Id = 12, Name = "Biləsuvar" },
                new City { Id = 13, Name = "Cəbrayıl" },
                new City { Id = 14, Name = "Cəlilabad" },
                new City { Id = 15, Name = "Daşkəsən" },
                new City { Id = 16, Name = "Gədəbəy" },
                new City { Id = 17, Name = "Goranboy" },
                new City { Id = 18, Name = "Göyçay" },
                new City { Id = 19, Name = "Göygöl" },
                new City { Id = 20, Name = "Hacıqabul" },
                new City { Id = 21, Name = "Xaçmaz" },
                new City { Id = 22, Name = "Xızı" },
                new City { Id = 23, Name = "Xocalı" },
                new City { Id = 24, Name = "Xocavənd" },
                new City { Id = 25, Name = "İmişli" },
                new City { Id = 26, Name = "İsmayıllı" },
                new City { Id = 27, Name = "Kəlbəcər" },
                new City { Id = 28, Name = "Kürdəmir" },
                new City { Id = 29, Name = "Qax" },
                new City { Id = 30, Name = "Qazax" },
                new City { Id = 31, Name = "Qəbələ" },
                new City { Id = 32, Name = "Qobustan" },
                new City { Id = 33, Name = "Quba" },
                new City { Id = 34, Name = "Qubadlı" },
                new City { Id = 35, Name = "Qusar" },
                new City { Id = 36, Name = "Laçın" },
                new City { Id = 37, Name = "Lerik" },
                new City { Id = 38, Name = "Lənkəran" },
                new City { Id = 39, Name = "Masallı" },
                new City { Id = 40, Name = "Neftçala" },
                new City { Id = 41, Name = "Oğuz" },
                new City { Id = 42, Name = "Saatlı" },
                new City { Id = 43, Name = "Sabirabad" },
                new City { Id = 44, Name = "Salyan" },
                new City { Id = 45, Name = "Samux" },
                new City { Id = 46, Name = "Siyəzən" },
                new City { Id = 47, Name = "Şabran" },
                new City { Id = 48, Name = "Şamaxı" },
                new City { Id = 49, Name = "Şəki" },
                new City { Id = 50, Name = "Şəmkir" },
                new City { Id = 51, Name = "Şuşa" },
                new City { Id = 52, Name = "Tərtər" },
                new City { Id = 53, Name = "Tovuz" },
                new City { Id = 54, Name = "Ucar" },
                new City { Id = 55, Name = "Yardımlı" },
                new City { Id = 56, Name = "Yevlax" },
                new City { Id = 57, Name = "Zaqatala" },
                new City { Id = 58, Name = "Zəngilan" },
                new City { Id = 59, Name = "Zərdab" }
               );

            builder.Entity(typeof(Region)).HasData(
              new Region { Id = 1, Name = "Abşeron r.", CityId = 10 },
              new Region { Id = 2, Name = "Binəqədi r.", CityId = 10 },
              new Region { Id = 3, Name = "Nizami r.", CityId = 10 },
              new Region { Id = 4, Name = "Nərimanov r.", CityId = 10 },
              new Region { Id = 5, Name = "Nəsimi r.", CityId = 10 },
              new Region { Id = 6, Name = "Pirallahı", CityId = 10 },
              new Region { Id = 7, Name = "Qaradağ r.", CityId = 10 },
              new Region { Id = 8, Name = "Sabunçu r.", CityId = 10 },
              new Region { Id = 9, Name = "Suraxanı r.", CityId = 10 },
              new Region { Id = 10, Name = "Səbail r.", CityId = 10 },
              new Region { Id = 11, Name = "Xətai r.", CityId = 10 },
              new Region { Id = 12, Name = "Xəzər r.", CityId = 10 },
              new Region { Id = 13, Name = "Yasamal r.", CityId = 10 }
                 );

            builder.Entity(typeof(Village)).HasData(
            new Village { Id = 1, Name = "1mkr" },
            new Village { Id = 2, Name = "2mkr" },
            new Village { Id = 3, Name = "20-ci sahə" },
            new Village { Id = 4, Name = "28 May" },
            new Village { Id = 5, Name = "3mkr" },
            new Village { Id = 6, Name = "4mkr" },
            new Village { Id = 7, Name = "5mkr" },
            new Village { Id = 8, Name = "6mkr" },
            new Village { Id = 9, Name = "7mkr" },
            new Village { Id = 10, Name = "8mkr" },
            new Village { Id = 11, Name = "9mkr" },
            new Village { Id = 12, Name = "Ağ şəhər" },
            new Village { Id = 13, Name = "Alatava 1" },
            new Village { Id = 14, Name = "Alatava 2" },
            new Village { Id = 15, Name = "Badamdar" },
            new Village { Id = 16, Name = "Bahar" },
            new Village { Id = 17, Name = "Bakixanov" },
            new Village { Id = 18, Name = "Balaxnı" },
            new Village { Id = 19, Name = "Bayıl" },
            new Village { Id = 20, Name = "Bibiheybət" },
            new Village { Id = 21, Name = "Bilgəh" },
            new Village { Id = 22, Name = "Biləcəri" },
            new Village { Id = 23, Name = "Binə" },
            new Village { Id = 24, Name = "Binəqədi" },
            new Village { Id = 25, Name = "Böyükşor" },
            new Village { Id = 26, Name = "Bülbülə" },
            new Village { Id = 27, Name = "Buzovna" },
            new Village { Id = 28, Name = "Çermet " },
            new Village { Id = 29, Name = "Ceyranbatan" },
            new Village { Id = 30, Name = "Çiçək" },
            new Village { Id = 31, Name = "Corat" },
            new Village { Id = 32, Name = "Digah" },
            new Village { Id = 33, Name = "Dübəndi bağları" },
            new Village { Id = 34, Name = "Dədə Qorqud" },
            new Village { Id = 35, Name = "Fatmayı" },
            new Village { Id = 36, Name = "Görədil" },
            new Village { Id = 37, Name = "Güzdək" },
            new Village { Id = 38, Name = "Hökməli" },
            new Village { Id = 39, Name = "Hövsan" },
            new Village { Id = 40, Name = "Həzi Aslanov merkez" },
            new Village { Id = 41, Name = "Keşlə" },
            new Village { Id = 42, Name = "Kimya şəhərciyi" },
            new Village { Id = 43, Name = "Köhnə Günəşli" },
            new Village { Id = 44, Name = "Kürdəxanı " },
            new Village { Id = 45, Name = "Lökbatan" },
            new Village { Id = 46, Name = "Ləhic Bağları" },
            new Village { Id = 47, Name = "Masazır" },
            new Village { Id = 48, Name = "Maştağa" },
            new Village { Id = 49, Name = "Mehdiabad" },
            new Village { Id = 50, Name = "Montin" },
            new Village { Id = 51, Name = "Müşfiqabad" },
            new Village { Id = 52, Name = "Məhəmmədli" },
            new Village { Id = 53, Name = "Mərdəkan" },
            new Village { Id = 54, Name = "Nardaran" },
            new Village { Id = 55, Name = "Nasosnu" },
            new Village { Id = 56, Name = "Novxanı" },
            new Village { Id = 57, Name = "Nübar" },
            new Village { Id = 58, Name = "NZS" },
            new Village { Id = 59, Name = "Papanin" },
            new Village { Id = 60, Name = "Perekeşkül" },
            new Village { Id = 61, Name = "Pirşağı" },
            new Village { Id = 62, Name = "Puta" },
            new Village { Id = 63, Name = "Qala" },
            new Village { Id = 64, Name = "Qara şəhər" },
            new Village { Id = 65, Name = "Qaraçuxur" },
            new Village { Id = 66, Name = "Qızıldaş" },
            new Village { Id = 67, Name = "Qobu" },
            new Village { Id = 68, Name = "Qobustan" },
            new Village { Id = 69, Name = "Ramana" },
            new Village { Id = 70, Name = "Rəsulzadə" },
            new Village { Id = 71, Name = "Sabunçu" },
            new Village { Id = 72, Name = "Şağan" },
            new Village { Id = 73, Name = "Sahil" },
            new Village { Id = 74, Name = "Saray" },
            new Village { Id = 75, Name = "Savalan" },
            new Village { Id = 76, Name = "Şıxov" },
            new Village { Id = 77, Name = "Şubanı" },
            new Village { Id = 78, Name = "Sulutəpə" },
            new Village { Id = 79, Name = "Şuşa" },
            new Village { Id = 80, Name = "Şüvəlan" },
            new Village { Id = 81, Name = "Səngəçal" },
            new Village { Id = 82, Name = "Türkan" },
            new Village { Id = 83, Name = "Ümid" },
            new Village { Id = 84, Name = "Xaşaxuna" },
            new Village { Id = 85, Name = "Xocəsən" },
            new Village { Id = 86, Name = "Xutor" },
            new Village { Id = 87, Name = "Y.Günəşli" },
            new Village { Id = 88, Name = "Y.Ramana" },
            new Village { Id = 89, Name = "Y.Suraxanı" },
            new Village { Id = 90, Name = "Yeni Yasamal" },
            new Village { Id = 91, Name = "Y.Suraxanı" },
            new Village { Id = 92, Name = "Zabrat 1" },
            new Village { Id = 93, Name = "Zabrat 2" },
            new Village { Id = 94, Name = "Zağulba" },
            new Village { Id = 95, Name = "Zığ" },
            new Village { Id = 96, Name = "Zirə" },
            new Village { Id = 97, Name = "Əhmədli" },
            new Village { Id = 98, Name = "Ələt" },
            new Village { Id = 99, Name = "Əmircan" }
               );

            builder.Entity(typeof(Metro)).HasData(
            new Metro { Id = 1, Name = "20 yanvar m." },
            new Metro { Id = 2, Name = "28 May m." },
            new Metro { Id = 3, Name = "Avtovağzal m." },
            new Metro { Id = 4, Name = "Azadlıq prospekti m." },
            new Metro { Id = 5, Name = "Bakmil m." },
            new Metro { Id = 6, Name = "Cəfər Cabbarlı m." },
            new Metro { Id = 7, Name = "Dərnəgül m." },
            new Metro { Id = 8, Name = "Elmlər Akademiyası m." },
            new Metro { Id = 9, Name = "Gənclik m." },
            new Metro { Id = 10, Name = "Həzi Aslanov m." },
            new Metro { Id = 11, Name = "İçəri Şəhər m." },
            new Metro { Id = 12, Name = "İnşaatçılar m." },
            new Metro { Id = 13, Name = "Koroğlu m." },
            new Metro { Id = 14, Name = "Memar Əcəmi m." },
            new Metro { Id = 15, Name = "Neftçilər m." },
            new Metro { Id = 16, Name = "Nizami m." },
            new Metro { Id = 17, Name = "Nəriman Nərimanov m." },
            new Metro { Id = 18, Name = "Nəsimi m." },
            new Metro { Id = 19, Name = "Qara Qarayev m." },
            new Metro { Id = 20, Name = "Şah İsmayıl Xətai m." },
            new Metro { Id = 21, Name = "Sahil m." },
            new Metro { Id = 22, Name = "Ulduz m." },
            new Metro { Id = 23, Name = "Xalqlar Dostluğu m." },
            new Metro { Id = 24, Name = "Əhmədli m." }
               );

            builder.Entity(typeof(NumberKeyCode)).HasData(
               new NumberKeyCode { Id = 1, Kcode = "050" },
               new NumberKeyCode { Id = 2, Kcode = "051" },
               new NumberKeyCode { Id = 3, Kcode = "055" },
               new NumberKeyCode { Id = 4, Kcode = "070" },
               new NumberKeyCode { Id = 5, Kcode = "077" },
               new NumberKeyCode { Id = 6, Kcode = "040" },
               new NumberKeyCode { Id = 7, Kcode = "060" },
               new NumberKeyCode { Id = 8, Kcode = "012" }
                );

            builder.Entity(typeof(NumberKeyCodeSecond)).HasData(
               new NumberKeyCodeSecond { Id = 1, Kcode = "050" },
               new NumberKeyCodeSecond { Id = 2, Kcode = "051" },
               new NumberKeyCodeSecond { Id = 3, Kcode = "055" },
               new NumberKeyCodeSecond { Id = 4, Kcode = "070" },
               new NumberKeyCodeSecond { Id = 5, Kcode = "077" },
               new NumberKeyCodeSecond { Id = 6, Kcode = "040" },
               new NumberKeyCodeSecond { Id = 7, Kcode = "060" },
               new NumberKeyCodeSecond { Id = 8, Kcode = "012" }
                );
        }
    }
}
