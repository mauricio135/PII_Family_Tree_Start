namespace Library
{
    public interface IVisitable<T>
    {
        void accept(IVisitor<T> visitor);
    }
}