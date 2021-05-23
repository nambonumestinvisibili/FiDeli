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
using FiDeli.Application.DTO;
using FiDeli.Infrastructure.Repos.IMRepos;
using FiDeli.ApplicationTests;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorService.Tests
{
    [TestClass()]
    public class CreateCommissionCommandHandlerTests
    {



        [TestMethod()]
        public async Task HandleTestAsync()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Commission, CommissionDTO>();
            });
            var mapper = new Mapper(config);
            var utils = new Utils();
            var commissionRepo = utils.commissionRepo;


            Commission commission = new Commission()
            {
                Commissioner = (await utils.CommissionerRepo.FindAll()).First(),
                Recipient = (await utils.recipientRepo.FindAll()).First(),
                Price = 10,
                TargetParceLocker = (await utils.parcelLockerRepo.FindAll()).First(),
                Parcel = (await utils.parcelRepo.FindAll()).First(),
                CommissionStatus = Domain.Statuses.CommissionStatus.Draft,
                DeliveryStatus = Domain.DeliveryStatus.NotStarted,
                

            };

            //var repo = new Mock<ICommissionRepo>();
            //Commission commission = new Commission() { Price = 10 };
            //var cmd = new CreateCommissionCommand(commission);
            //var ret = new CreateCommissionCommandHandler(repo.Object, _mapper);
            //var res = await ret.Handle(cmd, CancellationToken.None);
            //Assert.IsNotNull(res);
        }
    }
}