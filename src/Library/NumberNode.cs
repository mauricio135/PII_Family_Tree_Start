using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NumberNode
    {
        private int number;

        private List<NumberNode> children = new List<NumberNode>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<NumberNode> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public NumberNode(int number)
        {
            this.number = number;
        }

        public void AddChildren(NumberNode n)
        {
            this.children.Add(n);
        }

        public void Accept(SumVisitor v)
        {
            v.Visit(this);
        }
    }
}
