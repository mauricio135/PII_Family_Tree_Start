namespace Library
{
    public class LongestNameVisitor : IVisitor<Persona>
    {
        private Persona longName = new Persona("",0);
        public Persona LongName
        {
            get
            {
                return this.longName;
            }
        }
        public void visit(Node<Persona> nodo)
        {
            this.visit(nodo.Content);
            foreach (Node<Persona> son in nodo.Children)
            {
                this.visit(son);
            }
        }

        public void visit(Persona content)
        {
            if (content.Nombre.Length > this.longName.Nombre.Length)
            {
                this.longName = content;
            }
        }
    }
}