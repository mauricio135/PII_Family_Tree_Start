namespace Library
{    
    public interface IVisitor<T>
    {
        void visit (Node<T> nodo);
        void visit (T content);
    }
}
