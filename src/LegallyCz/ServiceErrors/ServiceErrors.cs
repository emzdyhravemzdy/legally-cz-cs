using ErrorOr;
using HraveMzdy.LegallyCz.Interfaces;

namespace HraveMzdy.LegallyCz.ServiceErrors;

public static partial class Errors
{
    public static class History
    {
        public static Error BundleNone(ILegallyPeriod period) => Error.Conflict("History.BundleNone", $"For period {period.Description}, service hasn't returned bundle");
        public static Error BundleNull(ILegallyPeriod period) => Error.NotFound("History.BundleNull", $"For period {period.Description}, service returned null bundle");
        public static Error BundleEmpty(ILegallyPeriod period) => Error.NotFound("History.BundleEmpty", $"For period {period.Description}, service returned empty bundle");
        public static Error BundleInvalid(ILegallyPeriod period) => Error.Failure("History.BundleInvalid", $"For period {period.Description}, service returned invalid bundle");
    }
}
