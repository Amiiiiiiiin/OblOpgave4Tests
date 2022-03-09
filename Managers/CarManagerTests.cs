using Microsoft.VisualStudio.TestTools.UnitTesting;
using OblOpgave4.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OblOpgave4.Models;
using Microsoft.AspNetCore.Mvc;

namespace OblOpgave4.Managers.Tests
{
    [TestClass()]
    public class CarManagerTests
    {
        private CarManager _carManager;

        [TestInitialize]
        public void SetUp()
        {
            _carManager = new CarManager();
        }

        [TestMethod()]
        public void TestGetAll()
        {
            Assert.IsNotNull(_carManager.GetAll(null));
        }

        [TestMethod()]
        public void TestGetById()
        {
            Assert.IsNotNull((_carManager.GetById(1)));
        }

        [TestMethod()]
        public void TestAdd()
        {
            Car carToCreate = new Car();
            Car carCreated = _carManager.AddCar(carToCreate);
            Assert.IsNotNull(carCreated);
            Assert.AreEqual(carToCreate, carCreated);
        }

        [TestMethod()]
        public void TestDelete()
        {
            new Car() {Id = 7, Model = "Test Bil", Price = 10, LicensePlate = "ABC123"};
            Car carDeleted = _carManager.Delete(7);
            Assert.IsNotNull(carDeleted);
        }
    }
}