using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contact
    {
        //bu classrta bir de constructor metodu eklemeliyiz. sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri constructor metotların içinde yaparız.
        //constructor (kurucu) metodların isimleri class isimleriyle aynı olmalı. public olmalı. geri dönüş değerleri yok.
        public Contact(string name, string number)  //kısaca ctor diyerek oluşturduk.
        {
            Name = name;  //Name property name parametresi olarak ayarlandı.
            Number = number;
        }
        //bu classta two properties var 
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
