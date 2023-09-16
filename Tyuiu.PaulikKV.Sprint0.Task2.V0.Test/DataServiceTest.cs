﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PaulikKV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Кирилл";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Кирилл", res);
        }
    }
}
