namespace Library
{
    public class NodoPersona : Node<Persona>
    {
        public NodoPersona (Persona content) : base (content)
        { }

        public override void accept (IVisitor<Persona> visitor)
        {
            visitor.visit (this);
        }

        public override int visit (Persona persona)
        {
            return persona.Edad();
        }
    }