/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using za.co.grindrodbank.a3s.Models;
using za.co.grindrodbank.a3s.Repositories;

namespace za.co.grindrodbank.a3s.tests.Fakes
{
    public class ApplicationRepositoryFake : IApplicationRepository
    {
        ApplicationModel mockedApplicationModel;

        public ApplicationRepositoryFake()
        {
        }

        public ApplicationRepositoryFake(ApplicationModel mockedApplicationModel)
        {
            this.mockedApplicationModel = mockedApplicationModel;
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationModel> CreateAsync(ApplicationModel application)
        {
            // return the application as we want to interrogate it.
            return Task.FromResult(application);
        }

        public Task<ApplicationModel> GetByIdAsync(Guid applicationId)
        {
            return Task.FromResult(mockedApplicationModel);
        }

        public Task<ApplicationModel> GetByNameAsync(string name)
        {
            return Task.FromResult(mockedApplicationModel);
        }

        public Task<List<ApplicationModel>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public void InitSharedTransaction()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationModel> Update(ApplicationModel application)
        {
            // return the application as we want to interrogate it.
            return Task.FromResult(application);
        }
    }
}
