using Eventinars.Application.Interfaces.Services;
using System;

namespace Eventinars.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}