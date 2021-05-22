using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiDeli.Application.Automapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiDeli.Domain.Core.Commissions;

namespace FiDeli.Application.Automapper.Tests
{
    [TestClass()]
    public class DTOProfileTests
    {
        [TestMethod()]
        public void DTOProfileTest()
        {
            Commission cms = new Commission { Price = 10};

        }
    }
}