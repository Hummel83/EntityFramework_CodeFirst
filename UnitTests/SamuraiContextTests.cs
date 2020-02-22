using System;
using System.Collections.Generic;
using System.Linq;
using Sqlite.Data;
using Sqlite.Domain;
using Xunit;

namespace UnitTests
{
    public class SamuraiContextTests : IDisposable
    {
        public SamuraiContextTests()
        {
            _context = new SamuraiContext();
        }

        private readonly SamuraiContext _context;

        private List<Samurai> GetSamurai()
        {
            var samurais = _context.Samurais.ToList();
            return samurais;
        }

        private void AddOneSamurai()
        {
            var samurai = new Samurai {Name = "Eselkopf"};
            _context.Samurais.Add(samurai);
            _context.SaveChanges();
        }

        private void DeleteAllSamuraiItems()
        {
            var deleteItems = GetSamurai();
            _context.Samurais.RemoveRange(deleteItems);
            _context.SaveChanges();
        }

        [Fact]
        public void TestCreateDB()
        {
            //Arrange
            var expect = "Eselkopf";
            _context.Database.EnsureCreated();
            AddOneSamurai();

            // Act
            var samu = GetSamurai();
            var actual = samu.FirstOrDefault()?.Name;

            

            //Assert
            Assert.Equal(expect, actual);

            //cleanUp
            DeleteAllSamuraiItems();
            Dispose();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}