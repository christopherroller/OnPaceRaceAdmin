using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnPaceRaceAdmin.Models;

namespace OnPaceRaceAdmin.Repository
{
    public interface IRunnerRepository
    {
        Task<IEnumerable<Runner>> GetAllRunnersByRaceId(int Id);
        Task<Runner> GetRunnerById(int Id);
        Task CreateRunner(Runner runner);
        Task UpdateRunner(Runner runner);
        Task DeleteRunner(Runner runner);


    }
}
