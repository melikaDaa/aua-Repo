using Microsoft.Extensions.DependencyInjection;

namespace AUA.ProjectName.Blazor.RegistrationServices
{
    public static class StartUpServices
    {
        public static void RegistrationServicesBlazor(this IServiceCollection services)
        {
            services.RegistrationValidationService();

            services.RegistrationGeneralServices();

            services.RegistrationBusinessService();

            services.RegistrationEntitiesService();

            services.RegistrationExWebService();

            services.RegistrationToStaticIoc();

            services.RegistrationInMemoryService();

            services.RegistrationListService();

            services.RegistrationBlazorServices();
        }


        private static void RegistrationToStaticIoc(this IServiceCollection services)
        {
            // Inject in static class(Unrecommend)

            // ServiceFactory.ServiceProvider = services.BuildServiceProvider();
        }

    }
}
