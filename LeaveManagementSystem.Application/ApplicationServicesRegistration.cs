﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ILeaveTypesService, LeaveTypesService>();
            services.AddScoped<ILeaveAllocationsService, LeaveAllocationsService>();
            services.AddTransient<ILeaveRequestsService, LeaveRequestsService>();
            services.AddScoped<IPeriodsService, PeriodsService>();
            services.AddScoped<IUserService, UserService>();
            services.AddTransient<IEmailSender, EmailSender>();
            return services;
        }
    }
}
