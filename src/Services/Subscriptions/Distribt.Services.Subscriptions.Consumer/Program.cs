using Distribt.Services.Subscriptions.Consumer.Handler;

WebApplication app = DefaultDistribtWebApplication.Create(x =>
{
    x.Services.AddScoped<IDependenciaTest, DependenciaTest>();
    x.Services.AddHandlersInAssembly<SubscriptionHandler>();
    x.Services.AddServiceBusIntegrationConsumer<SubscriptionHandler>(x.Configuration);
});


DefaultDistribtWebApplication.Run(app);