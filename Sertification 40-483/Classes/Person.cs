using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertification_40_483.Classes
{
    public class Person: IEnumerable
    {
        int[] persons;

        public Person()
        {
            persons = new int[] { 1, 2, 3, 4, 5 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    internal class PersonEnum : IEnumerator
    {
        int[] _persons;
        private int _position;

        public PersonEnum(int[] list)
        {
            _persons = list;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _persons.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return _persons[_position];
            }
        }
    }
}
