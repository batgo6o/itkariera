using System.Collections;
using System.Collections.Generic;

namespace yield
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
            for (int i = 0; i < Student.Count; i++)
            {
                yield return Student[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}