﻿using SpaceX.Infrastructure;

namespace SpaceX.API

            services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(ApplicationLayer).Assembly));