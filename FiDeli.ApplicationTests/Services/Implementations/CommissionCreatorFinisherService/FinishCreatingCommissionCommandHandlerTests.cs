using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiDeli.Application.Services.Implementations.CommissionCreatorFinisherService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FiDeli.Domain.Core.Commissions;
using FiDeli.ApplicationTests;
using FiDeli.Application.DTO;
using FiDeli.Domain;
using System.Threading;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorFinisherService.Tests
{
    [TestClass()]
    public class FinishCreatingCommissionCommandHandlerTests
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
            var parcelLockerRepo = utils.parcelLockerRepo;

            var cmr = (await utils.CommissionerRepo.FindAll()).First();
            var rcp = (await utils.recipientRepo.FindAll()).First();
            var parlock = (await utils.parcelLockerRepo.FindAll()).First();
            var parc = (await utils.parcelRepo.FindAll()).First();

            Commission commission = new Commission()
            {
                Commissioner = cmr,
                Recipient = rcp,
                Price = 10,
                TargetParceLocker = parlock,
                Parcel = parc,
                CommissionStatus = Domain.Statuses.CommissionStatus.Draft,
                DeliveryStatus = Domain.DeliveryStatus.NotStarted,
                Id = 100

            };

            await commissionRepo.Add(commission);

            Commission lightCommission = new Commission()
            {
                Id = 100
            };

            ParcelLocker pr = (await utils.parcelLockerRepo.FindAll()).ElementAt(1);

            FinishCreatingCommissionCommand cmd = new FinishCreatingCommissionCommand(commission, pr);

            FinishCreatingCommissionCommandHandler handler = new FinishCreatingCommissionCommandHandler(commissionRepo, parcelLockerRepo, mapper);

            await handler.Handle(cmd, CancellationToken.None);

            var updatedCommission = (await commissionRepo.FindById(100));

            Assert.IsTrue(
                    updatedCommission.SourceParcelLocker == pr
                );
        }
    }
}