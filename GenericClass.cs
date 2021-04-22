using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatesForTypesAndMethods_5_
{
    class GenericClass<T, S, N, K> : IComparable<GenericClass<T,S,N,K>> where T : IComparable<T>
    {
        private T identifier;
        private S genericTypeS;
        private N genericTypeN;
        private K genericTypeK;

        public T Identifier {
            get { return identifier; }
            set { identifier = value; }
        }
        public S GenericTypeS {
            get { return genericTypeS; }
            set { genericTypeS = value; }
        }
        public N GenericTypeN {
            get { return genericTypeN; }
            set { genericTypeN = value; }
        }
        public K GenericTypeK {
            get { return genericTypeK; }
            set { genericTypeK = value; }
        }
        
        public int CompareTo(GenericClass<T,S,N,K> obj)
        {
            return this.Identifier.CompareTo(obj.Identifier);
        }

        public GenericClass(T identifier, S genericTypeS, N genericTypeN, K genericTypeK)
        {
            Identifier = identifier;
            GenericTypeS = genericTypeS;
            GenericTypeN = genericTypeN;
            GenericTypeK = genericTypeK;
        }

        public GenericClass()
        {
        }

        public override string ToString()
        {
            return $"Identifier: {Identifier}, S: {GenericTypeS}, N: {GenericTypeN}, K: {GenericTypeK}";
        }

        public override bool Equals(object obj)
        {
            return obj is GenericClass<T, S, N, K> @class &&
                   EqualityComparer<T>.Default.Equals(Identifier, @class.Identifier) &&
                   EqualityComparer<S>.Default.Equals(GenericTypeS, @class.GenericTypeS) &&
                   EqualityComparer<N>.Default.Equals(GenericTypeN, @class.GenericTypeN) &&
                   EqualityComparer<K>.Default.Equals(GenericTypeK, @class.GenericTypeK);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Identifier, GenericTypeS, GenericTypeN, GenericTypeK);
        }
    }
}
