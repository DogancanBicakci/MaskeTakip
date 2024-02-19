using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //Encapsulation denir bu metota, gerekli parametreleri bir metot içinde tutuyorum. Yeni bir şey gelirse içine ekle patlamaz...
        public void ApplyForMask(Person person);

        public List<Person> GetList();

        public bool CheckPerson(Person person);
        
    }
}
