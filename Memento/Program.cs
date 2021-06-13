using System;

namespace Memento
{
    /// <summary>
    /// Memento
    /// Recuerdo
    /// Permite volver al estado anterior de un objeto
    /// Permite realizar una copia
    ///
    /// Requiere 2 metodos
    /// - Uno para obtener un estado del objeto
    /// - Otro para para revertir el cambio
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            User user = new User()
            {
                Age =  "45",
                Name = "Nombre"
            };

            User userSnapshot = user.GetMemento();
            
            user.Age = "789798";
            user.Name = "Nombreeeee";

            Console.WriteLine(user);
            
            user.RestartMemento(userSnapshot);

            Console.WriteLine(user);

        }
    }


    /// <summary>
    /// Para setear el nuevo estado del objeto
    /// </summary>
    class User
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }




        /// <summary>
        /// Get current State
        /// se crea un nuevo objeto
        /// con los todos los atributos actuales
        /// </summary>
        public User GetMemento()
        {
            return new User
            {
                Age = this.Age,
                Name = this.Name,
            };
        }


        public void RestartMemento(User user)
        {
            // para cada atributo, el setter necesario
            Age = user.Age;
            Name = user.Name;
        }
        
    }
}