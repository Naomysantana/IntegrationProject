

using Doaqui.src.models;
using System.Collections.Generic;

namespace Doaqui.src.repositories
{

    /// <summary>
    /// <para> Summary: Represets all CRUD actions related to requests </para>
    /// <para> Created by: Nickole Bueno </para>
    /// <para> Version: 1.0 </para>
    /// <para> Date: 05/05/2022 </para>
    /// </summary>
    public interface ISolicitacao
    {
        public void NewRequest();
        public void UpdateRequest();
        public void DeleteRequest();
        public SolicitacaoModel GetRequestById(int id);
        public List<SolicitacaoModel> GetAllRequests();
    }

}