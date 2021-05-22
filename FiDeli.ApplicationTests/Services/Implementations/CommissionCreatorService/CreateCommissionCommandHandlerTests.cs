using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiDeli.Application.Services.Implementations.CommissionCreatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiDeli.Domain.Core.Commissions;
using AutoMapper;
using Moq;
using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using System.Threading;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorService.Tests
{
    [TestClass()]
    public class CreateCommissionCommandHandlerTests
    {

        private IMapper _mapper;
        
        //[TestMethod()]
        //public  Task HandleTestAsync()
        //{
        //    //_mapper = mapper;

        //    //var repo = new Mock<ICommissionRepo>();
        //    //Commission commission = new Commission() { Price = 10 };
        //    //var cmd = new CreateCommissionCommand(commission);
        //    //var ret = new CreateCommissionCommandHandler(repo.Object, _mapper);
        //    //var res = await ret.Handle(cmd, CancellationToken.None);
        //    //Assert.IsNotNull(res);
        //}
    }
}