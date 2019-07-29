using System;
using System.Collections.Generic;

namespace ASM4
{
    public class PhoneBook : Phone
    {
        public List<PhoneNumber> PhoneList = new List<PhoneNumber>();

        public override bool InsertPhone(string name, string phone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    if (!p.Phone.Equals(phone))
                    {
                        p.Phone += ":" + phone;
                        return true;
                    }
                    return false;
                }
            }
            PhoneList.Add(new PhoneNumber(name, phone));
            return true;
        }
        

        public override bool RemovePhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    PhoneList.Remove(p);
                    return true;
                }
            }

            return false;
        }

        public override bool UpdatePhone(string name, string newphone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    p.Phone = newphone;
                    return true;
                }
            }
            
            return false;
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }

            return null;
        }
    }
}