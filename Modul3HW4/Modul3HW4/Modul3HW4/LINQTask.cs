using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class LINQTask
    {
        private Contact[] _contacts;
        public LINQTask()
        {
            _contacts = new Contact[]
            {
                new Contact
                {
                    Name = "Yuriy",
                    Phone = "099-673-11"
                },
                new Contact
                {
                    Name = "Denis",
                    Phone = "099-854-24"
                },
                new Contact
                {
                    Name = "Nastya",
                    Phone = "099-88-2312"
                },
                new Contact
                {
                    Name = "Helen",
                    Phone = "099-570-11"
                },
                new Contact
                {
                    Name = "Volodia",
                    Phone = "099-55-88"
                },
                new Contact
                {
                    Name = "Rodion",
                    Phone = "032-673-11"
                },
                new Contact
                {
                    Name = "Helen",
                    Phone = "099-673-77"
                },
                new Contact
                {
                    Name = "Stepan",
                    Phone = "077-777-777"
                },
                new Contact
                {
                    Name = "Yuriy",
                    Phone = "011-243-743"
                },
                new Contact
                {
                    Name = "Yuriy",
                    Phone = "099-88-324"
                },
                new Contact
                {
                    Name = "Kolya",
                    Phone = "099-12-4328"
                },
                new Contact
                {
                    Name = "Maxim",
                    Phone = "099-77-9632"
                }
            };
        }

        public void Run()
        {
            var collection = _contacts.Where(c => c.Phone == "Yuriy");
            var strPhone = _contacts.Select(c => c.Phone).ToArray();
            var collection2 = collection.OrderBy(c => c.Name);
            var collection3 = _contacts.Where(c => c.Name == "Helen").Union(collection);
        }
    }
}
