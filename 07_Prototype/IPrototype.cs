using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Prototype
{
    public interface IPrototype
    {
        IPrototype Clone();
    }

    public class ConcreatPrototype1 : IPrototype
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IPrototype Clone()
        {
            var result=this.MemberwiseClone();
            return (ConcreatPrototype1)result;
        }
    }

    public class ConcreatPrototype2 : IPrototype
    {
        public int Id { get; set; }

        public ConcreatPrototype3 Data { get; set; }

        public ConcreatPrototype2()
        {
            Data = new ConcreatPrototype3();
        }


        public IPrototype Clone()
        {
            var result = (ConcreatPrototype2)MemberwiseClone();

            result.Data = (ConcreatPrototype3)Data.Clone();

            return result;
        }
    }

    public class ConcreatPrototype3 : IPrototype
    {

        public string FullName { get; set; }

        public string NationalCode { get; set; }

        public IPrototype Clone()
        {
            var result = this.MemberwiseClone();
            return (ConcreatPrototype3)result;
        }
    }
}
