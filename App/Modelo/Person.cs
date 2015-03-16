using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Person
    {

        #region "Atributos"
        private long id;
        private string name;
        private string address;
        private string city;
        private string state;
        private long pos;
        #endregion

        #region "Propiedades"
        public long Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public long Pos { set; get; }
        #endregion

        #region "Constructores"
        public Person()
        {
            this.id = 12345;
            this.name = "nombre y Apellidos";
            this.address = "Mi dirección";
            this.city = "Mi Ciudad";
            this.state = "Bolivar";
            this.pos = 13001;
        
        }
        public Person(long id, string name, string address, string city, string state, long pos)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.pos = pos;

        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
             return "\n_______________________________________" +
                                "\nIdentificacion: " + this.id +
                                "\nNames: " + this.name +
                                "\nAddress: " + this.address +
                                "\nCity: " + this.city +
                                "\nState: " + this.state +
                                "\nPOS: " + this.pos +
                                "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Person o = (Person)obj;
            bool result = false;

            if ((this.id == o.id) &&
                (this.name == o.name) &&
                (this.address == o.address) &&
                (this.city == o.city) &&
                (this.state == o.state) &&
                (this.pos == o.pos))

                result = true;

            return result;
        }
        #endregion

    }
}