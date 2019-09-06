using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models;
using OnPaceRaceAdmin.Models.Contracts;

namespace OnPaceRaceAdmin.Repository
{
    public class RunnerRepository : RepositoryBase<Runner>, IRunnerRepository
    {

        public RunnerRepository(AdminContext context):base(context)
        {
            this.context = context;
        }

        public async Task CreateRunner(Runner runner)
        {
            Create(runner);
            await SaveAsync();
        }

        public async Task DeleteRunner(Runner runner)
        {
            Delete(runner.Id);
            await SaveAsync();
        }

        public Task<IEnumerable<Runner>> GetAllRunnersByRaceId(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Runner>> GetAllRunners()
        {
            return await FindAll()
               .OrderBy(x => x.FirstName)
               .ToListAsync();
        }

        public async Task<Runner> GetRunnerById(int Id)
        {
            return await FindByCondition(r => r.Id.Equals(Id)).DefaultIfEmpty(new Runner()).SingleAsync(); 
        }

        public async Task UpdateRunner(Runner runner)
        {
            Update(runner.Id, runner);
            await SaveAsync();
        }
    }
}
