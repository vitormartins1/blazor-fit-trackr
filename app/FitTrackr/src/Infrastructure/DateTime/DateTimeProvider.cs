using FitTrackr.Application.Common.Services.DateTime;

namespace FitTrackr.Infrastructure.DateTime;

public class DateTimeProvider : IDateTimeProvider
{
    public System.DateTime UtcNow => System.DateTime.UtcNow;
}
