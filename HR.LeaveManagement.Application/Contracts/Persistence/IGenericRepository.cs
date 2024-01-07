using HR.LeaceMangement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contracts.Persistence
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> GetAsync(int id);
		Task<List<T>> GetByIdAsync();
		Task<T> CreateAsync(T entity);
		Task<T> UpdateAsync(T entity);
		Task<T> DeleteAsync(T entity);

	}

	public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
	{

	}

	public interface ILeaveAllocationTypeRepository : IGenericRepository<LeaveAllocation>
	{

	}

	public interface ILeaveRequestTypeRepository : IGenericRepository<LeaveRequest>
	{

	}
}
