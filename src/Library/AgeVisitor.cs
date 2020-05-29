namespace Library
{
    public class AgeVisitor : IVisitor<Persona>
    {
        private int ageTotal = 0;
        public int AgeTotal
        {
            get
            {
                return this.ageTotal;
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
            this.ageTotal += content.Edad;
        }
    }
}