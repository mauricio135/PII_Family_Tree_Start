namespace Library
{
    public class Persona: IVisitable<Persona>
    {
        private string nombre;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        private int edad;
        public int Edad
        {
            get
            {
            return this.edad;
            }
        }

        public Persona(string nombre , int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        } 
        public void accept(IVisitor<Persona> visitor)
	    {
		    visitor.visit(this);	
	    }

    }
}