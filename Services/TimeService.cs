// TimeService.cs
using HRM.Areas.Identity.Data;
using HRM.Models.hrms;
using Microsoft.EntityFrameworkCore;

public interface ITimeService
{
	DateTime GetCurrentTimeInIndia();
}

public class TimeService : ITimeService
{
	private readonly ApplicationDbContext _context;

	public TimeService(ApplicationDbContext context)
	{
		_context = context;
	}

	public DateTime GetCurrentTimeInIndia()
	{
		var query = "SELECT cast(SYSDATETIMEOFFSET() AT TIME ZONE 'India Standard Time' as datetime) AS CurrentTimeInPST";

		var currentTimeInPST = _context.getIndTime.FromSqlRaw<GetIndiaTime>(query).FirstOrDefault()?.CurrentTimeInPST;

		return currentTimeInPST ?? DateTime.MinValue;
	}
}

