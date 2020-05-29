namespace Library
{
    public class OldestSonVisitor : IVisitor<Persona>
    {
        private Persona oldest = new Persona("Dummy", 0);
        public Persona Oldest 
        {
            get
            {
                return this.oldest;
            }
        }
        public void visit(Node<Persona> nodo)
        {
            if (nodo.Children.Count == 0)
            {
                this.visit(nodo.Content);
            }
            else
            {
                foreach (Node<Persona> son in nodo.Children)
                {
                    this.visit(son);
                }
            }
        }

        public void visit(Persona content)
        {
            if (content.Edad > this.oldest.Edad)
            {
                this.oldest = content;
            }
        }
    }
}