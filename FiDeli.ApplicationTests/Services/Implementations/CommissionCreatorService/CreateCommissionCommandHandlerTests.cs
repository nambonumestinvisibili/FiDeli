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

            var cmr = (await utils.CommissionerRepo.FindAll()).First();
            var rcp = (await utils.recipientRepo.FindAll()).First();
            var parlock = (await utils.parcelLockerRepo.FindAll()).First();
            var parc = (await utils.parcelRepo.FindAll()).First();
            
            Commission commission = new Commission()
            {
                Commissioner =      cmr,
                Recipient =         rcp,
                Price =             10,
                TargetParceLocker = parlock,
                Parcel =            parc,
                CommissionStatus =  Domain.Statuses.CommissionStatus.Draft,
                DeliveryStatus =    Domain.DeliveryStatus.NotStarted,
                Id = 100

            };

            CreateCommissionCommand cmd = new CreateCommissionCommand(commission);

            

            CreateCommissionCommandHandler handler = new CreateCommissionCommandHandler(utils.commissionRepo, mapper);

            var response = await handler.Handle(cmd, CancellationToken.None);

            Assert.IsTrue(response.Output.GetType() == typeof(CommissionDTO));
            Assert.IsTrue(utils.commissionRepo.Exists(commission.Id) != null);

        }
    }
}