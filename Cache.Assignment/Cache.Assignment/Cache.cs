using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Assignment
{
    public class Cache
    {
        private static Dictionary<string, WeakReference> _cache;

        int regenCount = 0;

        public Cache()
        {
            _cache = new Dictionary<string, WeakReference>();
        }

        public int Count
        {
            get { return _cache.Count; }
        }

        public int RegenerationCount
        {
            get { return regenCount; }
        }

        public Person Get(string name)
        {
            if (_cache.ContainsKey(name) == false)
                return null;

            Person person = _cache[name].Target as Person;

            return person;
        }

        public void Add(string key, Person person)
        {
            if (string.IsNullOrEmpty(key) || person == null)
                return;
            _cache.Add(key, new WeakReference(person, false));
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void Clear()
        {
            _cache = new Dictionary<string, WeakReference>();
        }
    }
}
