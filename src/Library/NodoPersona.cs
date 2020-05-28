namespace Library
{
    public class NodoPersona : Node<Persona>, IVisitable<Persona>
    {
        public NodoPersona (Persona content) : base (content)
        { }

        public override void accept (IVisitor<Persona> visitor)
        {
            visitor.visit (this);
        }
    }
}