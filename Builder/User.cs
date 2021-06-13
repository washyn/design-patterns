namespace Builder
{
    
    /// <summary>
    ///
    /// 
    /// 
    /// Minimo 3 metodos deberia implementar la
    /// 
    /// Make 1
    /// Build 1
    /// SetPropiedad ninguno o varios
    ///
    /// PAra crear el objeto se debe pasar por el build,
    /// no se puede crear una instancia de la clase,
    /// la clase tambien tiene un mecanismo 
    /// para no dejarse instanciar
    /// </summary>
    class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        private User(string name, string surName)
        {
            Name = name;
            SurName = surName;
        }

        public User SetEmail(string email)
        {
            Email = email;
            // para poder seguir agregando mas propiedades y hacer el build
            return this;
        }
        
        public User SetAddress(string address)
        {
            Address = address;
            // para poder seguir agregando mas propiedades y hacer el build
            return this;
        }

        public User SetPhoneNumber(string phone)
        {
            PhoneNumber = phone;
            // para poder seguir agregando mas propiedades y hacer el build
            return this;
        }

        
        
        /// <summary>
        /// Make, por convencion
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
        public static User Make(string name, string surname)
        {
            return new User(name,surname);
        }

        /// <summary>
        /// Build, por convencion
        /// </summary>
        /// <returns></returns>
        public User Build()
        {
            return this;
        }
        
        public override string ToString()
        {
            // return base.ToString();
            return $"{Name} {SurName} {Email} {Address} {PhoneNumber}";
        }
    }
    
}