using DodgeBall.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeBall.Web.Adapter.Interfaces
{
    public interface IDodgeBallAdapter
    {
        List<Team> GetAllTeams();
        Team GetTeam(int id);
        void AddTeam(Team team);
        void EditTeam(Team team);
    }
}
