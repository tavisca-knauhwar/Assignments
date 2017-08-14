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

        public object Get(string name)
        {
            if (_cache.ContainsKey(name) == false)
                return null;

            return _cache[name].Target;
        }

        public void Add(string key, Object obj)
        {
            if (string.IsNullOrEmpty(key) || obj == null)
                return;
            if (_cache.ContainsKey(key))
                return;
            _cache.Add(key, new WeakReference(obj, false));
        }
        public void Update(string key, Object obj)
        {
            _cache[key] = new WeakReference(obj, false);
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
