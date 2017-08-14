using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cache.Assignment.Test
{
    [TestClass]
    public class CacheTextFixtures
    {
        private Cache _cache;
        [TestInitialize]
        public void Initialize()
        {
            _cache = new Cache();
        }

        [TestMethod]
        public void AddObjToCacheTest()
        {
            _cache.Add(DataSource.GetPerson().ToString(), DataSource.GetPerson());
            Assert.IsTrue(_cache.Count == 1);
        }

        [TestMethod]
        public void AddMultipleObjectsToCache()
        {
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            Assert.IsNotNull(_cache);

        }

        [TestMethod]
        public void AddNullObjToCacheTest()
        {
            _cache.Add("Random", null);
            Assert.IsTrue(_cache.Count == 0);
        }

        [TestMethod]
        public void AddObjWithEmptyKeyToCacheTest()
        {
            _cache.Add(string.Empty, DataSource.GetPerson());
            Assert.IsTrue(_cache.Count == 0);
        }

        [TestMethod]
        public void GetObjFromCacheTest()
        {
            _cache.Add(DataSource.GetPerson().ToString(), DataSource.GetPerson());
            var obj = _cache.Get(DataSource.GetPerson().ToString());
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public void GetRandomObjFromCache()
        {
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            _cache.Add(DataSource.RandomString(7), DataSource.GetRandomPerson());
            var str = DataSource.RandomString(7);
            _cache.Add(str, DataSource.GetRandomPerson());
            var obj = _cache.Get(str);
            Assert.IsNotNull(obj);

        }


        [TestMethod]
        public void RemoveObjectFromCache()
        {
            _cache.Add(DataSource.GetPerson().ToString(), DataSource.GetPerson());
            _cache.Remove(DataSource.GetPerson().ToString());
            Assert.IsTrue(_cache.Count==0);
        }

        [TestMethod]
        public void RemoveObjectNotExistingInCache()
        {
            _cache.Add(DataSource.GetPerson().ToString(), DataSource.GetPerson());
            _cache.Remove("Hakuna Matata");
            Assert.IsTrue(_cache.Count == 1);
        }

        [TestMethod]
        public void ClearCache()
        {
            _cache.Add(DataSource.GetPerson().ToString(), DataSource.GetPerson());
            _cache.Clear();
            Assert.IsTrue(_cache.Count==0);
        }
    }
}
