using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Storium.Infrastructure.Data;

namespace Storium.Infrastructure.Services
{
    public class MigrationService
    {
        private readonly StoriumDbContext _context;
        private readonly ILogger<MigrationService> _logger;

        public MigrationService(StoriumDbContext context, ILogger<MigrationService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task ApplyMigrationsAsync()
        {
            try
            {
                _logger.LogInformation("Applying database migrations...");
                await _context.Database.MigrateAsync();
                _logger.LogInformation("Database migrations applied successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while applying database migrations.");
                throw; // Re-throw the exception for higher-level handling if necessary
            }
        }
    }
}
