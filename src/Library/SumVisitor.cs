namespace Library
{
    public class SumVisitor
    {
        private int sum = 0;

        public int Sum
        {
            get
            {
                return this.sum;
            }
        }

        public void Visit(NumberNode node)
        {
            sum += node.Number;
            foreach(NumberNode child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}