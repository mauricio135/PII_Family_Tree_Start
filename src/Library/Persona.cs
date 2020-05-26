namespace Library
{
    public class Persona
    {
        private string Nombre { get; set;}
        private int edad;
        public int Edad()
        {
            return this.edad;
        }

        public Persona(string nombre , int edad)
        {
            this.Nombre = nombre;
            this.edad = edad;
        } 
        public void accept(IVisitor<Persona> visitor)
	{
		visitor.visit(this);	
	}

    }
}