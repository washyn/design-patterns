using System;

namespace Builder
{
    /// <summary>
    /// Constructor,
    /// Mecanismo por el cual permite, la creacion de objetos de una manera particular
    /// cuando la creacion del objeto es compleja o debe seguir ciertas reglas
    ///
    /// El objeto buildeable, debe implementar 3 metodos(al parecer)
    /// - Make, parece opciona
    /// - Build, generalmente se ejecuta al final
    /// - SetProperti, permite modificaciones al objeto en el momento de su creacion
    ///
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            User user = User.Make("Nombre","Apellido")
                .SetAddress("Calle_1")
                .SetPhoneNumber("4546546546")
                .Build();

            Console.WriteLine(user.ToString());
            
        }
    }

    
}