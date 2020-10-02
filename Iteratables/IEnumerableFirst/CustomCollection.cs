using System.Collections;
using System.Collections.Generic;

namespace IEnumerableFirst
{
    class CustomCollection : IEnumerable<string>
    {
        private readonly List<string> Student;

        public CustomCollection(List<string> stInput)
        {
            Student = stInput;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new CustomEnumerator(Student);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        class CustomEnumerator : IEnumerator<string>
        {

            int currentIndex = 0;
            private readonly List<string> student;

            public CustomEnumerator(List<string> Student)
            {
                Reset();
                student = Student;
            }

            public string Current => student[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose(){}

            public bool MoveNext()
            {
                return ++currentIndex < student.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}