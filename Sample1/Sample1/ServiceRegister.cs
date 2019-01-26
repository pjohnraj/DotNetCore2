using Microsoft.Extensions.DependencyInjection;

namespace Sample
{
    using Repository;
    using Repository.Implementation;

    public class ServiceRegister
    { 
        public ServiceRegister(IServiceCollection services)
        {
            services.AddTransient<IPieRepository, PieRepository>();
            services.AddTransient<IFeedBackReposistory, FeedBackReposistory>();
        }
    }
}
