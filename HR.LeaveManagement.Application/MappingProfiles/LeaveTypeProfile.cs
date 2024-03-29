﻿using AutoMapper;
using HR.LeaceMangement.Domain;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.MappingProfiles
{
	public class LeaveTypeProfile : Profile
	{
		public LeaveTypeProfile() 
		{
			CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
		}
	}
}
