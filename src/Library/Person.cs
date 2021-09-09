using System;
//using System.Convert;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string fechaNacimiento)
        {
            this.Name = name;
            this.ID = id;
            this.FechaNacimiento = fechaNacimiento;
        }

        private string name;

        private string id;

        private string fechaNacimiento;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public string FechaNacimiento 
        {
            get
            {
                return this.fechaNacimiento;
            }

            set
            {
                if (!(string.IsNullOrEmpty(value)))
                {
                    string[] divisionFecha = value.Split("/");
                    if ((Convert.ToInt32(divisionFecha[0]) < 32)&&(Convert.ToInt32(divisionFecha[1]) < 13)&&(Convert.ToInt32(divisionFecha[2]) < 2022))
                    {
                        this.fechaNacimiento = value;
                    }
                    else 
                    {
                        this.fechaNacimiento = "01/01/1900";
                    }
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }
}
