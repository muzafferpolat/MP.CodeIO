
/*Bu bölgenin program ile alakası yoktur. MqlDb adında sanal bir database burada yapılmıştır. Programdaki veriler buradan çekilecektir.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalDatabese
{

    public class MqlDb
    {
        
        
        #region KategoriDepom
       public List<Category> categories = new List<Category>
        {
            {new Category(1,"Programlama")}
        };
        #endregion

        #region EğitmenDepom
       public List<Instructor> instructors = new List<Instructor>
        {
            { new Instructor(1, "Engin", "Demirog", "Yazılım geliştirmeye lisede \"yazılım\" bölümünde okurken başladım.\r\n\r\nÜniversite hayatıma ÖSS 2003 Türkiye derecesiyle başladım. Sırasıyla Başkent ve ODTÜ'de Yönetim Bilişim Sistemleri (Lisans-Burslu) ve Tıp Bilişimi(Yüksek Lisans) okudum. Profesyonel iş hayatıma ise henüz üniversite birinci sınıftayken başladım.\r\n\r\nAğırlıklı olarak Savunma Sanayisi, Bankacılık sektörlerine kurumsal yazılım geliştirme süreçleri konusunda danışmanlık veriyorum.\r\n\r\nMicrosoft Certified Trainer (MCT) ,PMP ve ITIL sertifikalarına sahibim.\r\n\r\n\"Engin Demiroğ\" YouTube kanalımda ücretsiz eğitim videoları ve içerikleri paylaşmaktayım.\r\n\r\nDanışmanlık yaptığım kurumların bazıları : Merkez Bankası,TAI, Birleşmiş Milletler,NATO,İş Bankası, Akbank, Halkbank, Vakıfbank, Yapı Kredi Bankası, Ziraat Bankası, Emniyet, Başbakanlık, Cumhurbaşkanlığı, Hazine Müsteşarlığı, Maliye Bakanlığı, Tarım Bakanlığı, Tübitak.\r\n\r\nDanışmanlık veya eğitim verdiğim kurum sayısı son 10 yılda 300'ü geçmiştir.\r\n\r\nDevFramework ismiyle geliştirdiğim altyapı projem birçok kurum ve firmada yazılım geliştirme altyapısı olarak kullanılmaktadır.", "https://www.filepicker.io/api/file/GsqiGFGCRmuBuel0qqF3") },
            { new Instructor(1, "Halit Enes", "Kalaycı", "Yazılım geliştirme sürecine lise sonuncu sınıfta başladım.\r\n\r\nSakarya Üniversitesi Yönetim Bilişim Sistemleri programından mezun oldum. \r\n\r\nProfesyonel iş hayatım üniversite 3. sınıfta başladı.\r\n\r\nKariyerime kodlama.io'da Yazılım Eğitmeni ve Danışmanı olarak devam ediyorum.\r\n\r\nEğitim ve danışmanlık verdiğim kurumların bazıları; Esbaş, Etiya, KDK, Turkcell, Bosch. \r\n\r\nkodlama.io olarak geliştirdiğimiz \"nArch\" projesinde aktif geliştirici olarak rol almaktayım.", "https://cdn.filestackcontent.com/XwoZsQ1LTaOU9ke59grx")}
        };
        #endregion

        #region KursDepom
       public List<Course> courses = new List<Course>
        {
            {new Course(1,"2024 Yazılım Geliştirici Yetiştirme Kampı (C#)","Gerçek hayatla ilişkilendirilmiş programlamaya giriş","https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/We86Zc3xQy6FUqhyBJJc",1)},
            {new Course(2,"(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium","String Interpolation, Listeler, Döngüler","https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/3nqAGqHARL6uEULbaQvr",2)}
        };
        #endregion
    }
    #region Class Tanımlamalarım
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public Instructor(int id, string firsName, string lastName, string comment, string image)
        {
            Id = id;
            FirstName = firsName;
            LastName = lastName;
            Comment = comment;
            Image = image;
        }
    }
    public class Course
    {
        public Course(int id, string title, string comment, string image, int instructorId)
        {
            Id = id;
            Title = title;
            Comment = comment;
            Image = image;
            InstructorId = instructorId;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public int InstructorId { get; set; }

    }
    #endregion
}
