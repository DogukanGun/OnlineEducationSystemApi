

using Hocam.Core.Data.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DbServiceExtensions
    {
        public static void AddDbServices(this IServiceCollection services)
        {
            services.AddSingleton<IQuizRepository,QuizRepository >();
            services.AddSingleton<ILogOnAuditRepository, LogOnAuditRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<ILessonRepository, LessonRepository>();

            
        }
    }
}
