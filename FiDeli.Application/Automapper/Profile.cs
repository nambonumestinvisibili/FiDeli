using AutoMapper;
using FiDeli.Application.DTO;
using FiDeli.Domain.Core.Commissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Automapper
{
    public class DTOProfile : Profile
    {
        public DTOProfile()
        {
            CreateMap<Commission,CommissionDTO>();
        }
    }
}
