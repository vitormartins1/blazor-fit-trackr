using FitTrackr.Application.Common.Services.DateTime;

namespace FitTrackr.Infrastructure.DateAndTime;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
